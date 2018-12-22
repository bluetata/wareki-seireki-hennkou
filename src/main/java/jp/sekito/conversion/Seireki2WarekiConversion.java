/**
 * Copyright (c) 2017-2018 Sekito Lv(bluetata) <sekito.lv@gmail.com>
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
package jp.sekito.conversion;

import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.List;

/***
 * 西暦 → 和暦 変更ツール
 *
 * @date     12/20/2018 19:10
 * @version  version(1.0)</br>
 * @author   bluetata(Sekito.Lv) / Sekito.Lv@gmail.com</br>
 * @since    JDK 1.8</br>
 *
 */
public class Seireki2WarekiConversion {

    // 西暦かどうか判定する
    public boolean checkDate(String sDay) {

        // 正規表現でチェックする（西暦）
        if (sDay.matches("\\d{4}/\\d{1,2}/\\d{1,2}")) {
            // 日付かどうか判定する
            if (isDate(sDay))
                return true;
        }
        return false;
    }


    // 日付かどうか判定する
    private static boolean isDate(String strDate) {
        DateFormat dateFormat = new SimpleDateFormat("yyyy/MM/dd");

        dateFormat.setLenient(false);
        try {
            dateFormat.parse(strDate);
            return true;
        } catch (Exception e) {
            return false;
        }
    }


    /**
     * 西暦変更する
     * @param d1
     * @return
     */
    public String warekiConversionApater(LocalDateTime d1) {

        //文字列を日付に返す
        String strDay = "";
        int iYear;

        //西暦を返還する（明治編）
        if (d1.isAfter(LocalDateTime.of(1868, 1, 24, 23, 59)) &&
                d1.isBefore(LocalDateTime.of(1912, 7, 30, 0, 0))) {

            //西暦から和暦に変換する
            iYear = d1.getYear() - 1867;

            //日付を返す
            if (iYear == 1) {
                strDay = "明治元年" + d1.getMonthValue() + "月" + d1.getDayOfMonth() + "日";
            } else {
                strDay = "明治" + iYear + "年" + d1.getMonthValue() + "月" + d1.getDayOfMonth() + "日";
            }

            return strDay;
        }

        // 西暦を返還する（大正編）
        if (d1.isAfter(LocalDateTime.of(1912, 7, 29, 23, 59)) &&
                d1.isBefore(LocalDateTime.of(1926, 12, 25, 0, 0))) {

            // 西暦から和暦に変換する
            iYear = d1.getYear() - 1911;

            // 日付を返す
            if (iYear == 1) {
                strDay = "大正元年" + d1.getMonthValue() + "月" + d1.getDayOfMonth() + "日";
            } else {
                strDay = "大正" + iYear + "年" + d1.getMonthValue() + "月" + d1.getDayOfMonth() + "日";
            }

            return strDay;
        }

        // 西暦を返還する（昭和編）
        if (d1.isAfter(LocalDateTime.of(1926, 12, 24, 23, 59)) &&
                d1.isBefore(LocalDateTime.of(1989, 1, 8, 0, 0))) {

            //西暦から和暦に変換する
            iYear = d1.getYear() - 1925;

            //日付を返す
            if (iYear == 1) {
                strDay = "昭和元年" + d1.getMonthValue() + "月" + d1.getDayOfMonth() + "日";
            } else {
                strDay = "昭和" + iYear + "年" + d1.getMonthValue() + "月" + d1.getDayOfMonth() + "日";
            }

            return strDay;
        }

        // 西暦を変換する（平成編）
        if (d1.isAfter(LocalDateTime.of(1989, 1, 7, 23, 59)) &&
                d1.isBefore(LocalDateTime.of(2019, 5, 1, 0, 0))) {

            //西暦から和暦に変換する
            iYear = d1.getYear() - 1988;

            //日付を返す
            if (iYear == 1) {
                strDay = "平成元年" + d1.getMonthValue() + "月" + d1.getDayOfMonth() + "日";
            } else {
                strDay = "平成" + iYear + "年" + d1.getMonthValue() + "月" + d1.getDayOfMonth() + "日";
            }

            return strDay;
        }

        // 西暦を変換する（新元号・德仁（暫定））
        if (d1.isAfter(LocalDateTime.of(2019, 4, 30, 23, 59))) {

            //西暦から和暦に変換する
            iYear = d1.getYear() - 2019;

            //日付を返す
            if (iYear == 0) {
                strDay = "新元号・德仁（暫定）元年" + d1.getMonthValue() + "月" + d1.getDayOfMonth() + "日";
            } else {
                strDay = "新元号・德仁（暫定）" + iYear + "年" + d1.getMonthValue() + "月" + d1.getDayOfMonth() + "日";
            }

            return strDay;
        }

        // それ以外
        strDay = "和暦は明治・大正・昭和・平成・德仁のみ対応しております";

        return strDay;

    }



    // メインテスト
    public static void main(String[] args) {

        String sDay[];
        Seireki2WarekiConversion seireki2WarekiConversion = new Seireki2WarekiConversion();

        List<String> testList = new ArrayList<>();

        testList.add("2018/12/05");
        testList.add("2018/02/05");
        testList.add("2018/2/5");
        testList.add("2019/05/01"); // 新元号

        testList.add("1868/11/30"); // 明治
        testList.add("1988/12/27"); // 昭和
        testList.add("1990/02/05"); // 平成

        testList.add("2018/02/30"); // 異常テストデータ


        for (String d : testList) {

            // 正常の場合、西暦変換（正規表現）
            if (seireki2WarekiConversion.checkDate(d)) {
                // 西暦変換
                // 文字を分割する。Spilitメソッドを使う
                sDay = d.split("/", 0);

                // 文字列を日付に変換する
                LocalDateTime ldt = LocalDateTime.of(Integer.parseInt(sDay[0]), Integer.parseInt(sDay[1]), Integer.parseInt(sDay[2]), 0, 0, 0);

                // 西暦変換する。
                System.out.println(d + " → " + seireki2WarekiConversion.warekiConversionApater(ldt));
            }

        }
    }
}
