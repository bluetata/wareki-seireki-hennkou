/**
 * Copyright (c) 2017-2019 Sekito Lv(bluetata) <sekito.lv@gmail.com>
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software && associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, &&/or sell
 * copies of the Software, && to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice && this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE && NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_version
{
    /***
     * 西暦 → 和暦 変更ツール
     *
     * @date     12/20/2018 19:10
     * @version  version(1.0)</br>
     * @author   bluetata(Sekito.Lv) / Sekito.Lv@gmail.com</br>
     */
    class Seireki2WarekiConversion
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");　// in processing

        }


        public String warekiConversionApater(DateTime d1)
        {

            // 文字列を日付に返す
            String strDay = "";
            int iYear;

            // 西暦を返還する（明治編）
            if (IsDatetimeAfter(d1, new DateTime(1868, 1, 24, 23, 59, 0)) &&
                    IsDatetimeBefore(d1, new DateTime(1912, 7, 30, 0, 0, 0)))
            {

                // 西暦から和暦に変換する
                iYear = d1.Year - 1867;

                // 日付を返す
                if (iYear == 1)
                {
                    strDay = "明治元年" + d1.Month + "月" + d1.Day + "日";
                }
                else
                {
                    strDay = "明治" + iYear + "年" + d1.Month + "月" + d1.Day + "日";
                }

                return strDay;
            }

            // 西暦を返還する（大正編）
            if (IsDatetimeAfter(d1, new DateTime(1912, 7, 29, 23, 59, 0)) &&
                    IsDatetimeBefore(d1, new DateTime(1926, 12, 25, 0, 0, 0)))
            {

                // 西暦から和暦に変換する
                iYear = d1.Year - 1911;

                // 日付を返す
                if (iYear == 1)
                {
                    strDay = "大正元年" + d1.Month + "月" + d1.Day + "日";
                }
                else
                {
                    strDay = "大正" + iYear + "年" + d1.Month + "月" + d1.Day + "日";
                }

                return strDay;
            }

            // 西暦を返還する（昭和編）
            if (IsDatetimeAfter(d1, new DateTime(1926, 12, 24, 23, 59, 0)) &&
                    IsDatetimeBefore(d1, new DateTime(1989, 1, 8, 0, 0, 0)))
            {

                // 西暦から和暦に変換する
                iYear = d1.Year - 1925;

                // 日付を返す
                if (iYear == 1)
                {
                    strDay = "昭和元年" + d1.Month + "月" + d1.Day + "日";
                }
                else
                {
                    strDay = "昭和" + iYear + "年" + d1.Month + "月" + d1.Day + "日";
                }

                return strDay;
            }

            // 西暦を変換する（平成編）
            if (IsDatetimeAfter(d1, new DateTime(1989, 1, 7, 23, 59, 0)) &&
                    IsDatetimeBefore(d1, new DateTime(2019, 5, 1, 0, 0, 0)))
            {

                //西暦から和暦に変換する
                iYear = d1.Year - 1988;

                //日付を返す
                if (iYear == 1)
                {
                    strDay = "平成元年" + d1.Month + "月" + d1.Day + "日";
                }
                else
                {
                    strDay = "平成" + iYear + "年" + d1.Month + "月" + d1.Day + "日";
                }

                return strDay;
            }

            // 西暦を変換する（新元号・德仁（暫定））
            if (IsDatetimeAfter(d1, new DateTime(2019, 4, 30, 23, 59, 0)))
            {

                // 西暦から和暦に変換する
                iYear = d1.Year - 2018;

                // 日付を返す
                if (iYear == 1)
                {
                    strDay = "新元号・德仁（暫定）元年" + d1.Month + "月" + d1.Day + "日";
                }
                else
                {
                    strDay = "新元号・德仁（暫定）" + iYear + "年" + d1.Month + "月" + d1.Day + "日";
                }

                return strDay;
            }

            // それ以外
            strDay = "和暦は明治・大正・昭和・平成・德仁のみ対応しております";

            return strDay;

        }



        // Checks if this date-time d1 is before the specified date-time d2.
        public bool IsDatetimeBefore(DateTime d1, DateTime d2)
        {

            if (DateTime.Compare(d1, d2) < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        // Checks if this date-time d1 is after the specified date-time d2.
        public bool IsDatetimeAfter(DateTime d1, DateTime d2)
        {

            if (DateTime.Compare(d1, d2) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
