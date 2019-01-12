/**
 * Copyright (c) 2017-2019 Sekito Lv(bluetata) <sekito.lv@gmail.com>
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
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
