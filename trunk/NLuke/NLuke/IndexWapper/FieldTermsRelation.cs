/**
 * author : yurow
 *      http://birdshover.cnblogs.com
 * description:
 *      
 * history : created by yurow 2009-8-25 16:47:44 
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using Lucene.Net.Index;
using NLuke.LuceneAPI;

namespace NLuke.IndexWapper {
    /// <summary>
    /// 字段与Term的关系处理类
    /// </summary>
    public class FieldTermsRelation {
        private static FieldTermsRelation cached;
        private IOpen open;

        public static FieldTermsRelation getInstance() {
            if (cached == null) {
                lock (typeof(FieldTermsRelation)) {
                    if (cached == null) {
                        cached = new FieldTermsRelation();
                        cached.open = CurrentIndex.GetCurrentOpendIndex();
                    }
                }
            }
            return cached;
        }

        private string[] fields;
        private object lockobj = new object();
        /// <summary>
        /// 获得所有的字段
        /// </summary>
        public string[] Fields {
            get {
                if (fields == null) {
                    lock (lockobj) {
                        if (fields == null) {
                            ICollection fieldCollection = open.Reader.GetFieldNames(IndexReader.FieldOption.ALL);
                            fields = new string[fieldCollection.Count];
                            IEnumerator tor = fieldCollection.GetEnumerator();
                            int i = 0;
                            while (tor.MoveNext()) {
                                DictionaryEntry entry = (DictionaryEntry)tor.Current;
                                fields[i++] = entry.Key.ToString();
                            }
                        }
                    }
                }
                return fields;
            }
        }
        /// <summary>
        /// 释放缓存的字段
        /// </summary>
        public void ResetFields() {
            lock (lockobj) {
                fields = null;
            }
        }

        private string currentField;
        /// <summary>
        /// 切换当前字段
        /// </summary>
        /// <param name="field"></param>
        public void CurrentFieldChanged(string field) {
            this.currentField = field;
        }
        /// <summary>
        /// 查找指定数目的Term
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public TermModel[] FindTerms(int num) {
            num++;
            TermInfoQueue queue = new TermInfoQueue(num);
            TermEnum enum2 = open.Reader.Terms();
            int count = 0;
            while (enum2.Next()) {
                string str = enum2.Term().Field();
                if ((currentField != null) && (!str.Equals(currentField))) {
                    continue;
                }
                if (enum2.DocFreq() > count) {
                    queue.Put(new TermModel(enum2.Term(), enum2.DocFreq()));
                    if (queue.Size() < num) {
                        continue;
                    }
                    queue.Pop();
                    count = ((TermModel)queue.Top()).Count;
                }
            }
            enum2.Close();
            TermModel[] modleArray = new TermModel[queue.Size()];
            for (int i = 0; i < modleArray.Length; i++) {
                modleArray[(modleArray.Length - i) - 1] = (TermModel)queue.Pop();
            }
            return modleArray;
        }
        /// <summary>
        /// 查找指定字段Term
        /// </summary>
        /// <param name="field"></param>
        /// <param name="text"></param>
        /// <param name="current"></param>
        /// <returns></returns>
        public TermModel FindTerm(string field, string text, bool current) {
            TermEnum enum2 = open.Reader.Terms();
            if (enum2.SkipTo(new Term(field, text))) {
                TermModel modle2 = null;
                while ((!current && enum2.Next() && field.Equals(enum2.Term().Field())) 
                    || current) {
                    modle2 = new TermModel(enum2.Term(), enum2.DocFreq());
                    break;
                } 
                enum2.Close();
                return modle2;
            }
            return null;
        }
    }
}
