*その他の言語：[中文](README-cn.md)、[English](README-en.md).*   


# 和暦と西暦の双方向変換


- [x] JAVA&nbsp;バージョン：[java-version](/java-version/src/main/java/jp/sekito/conversion)   
- [x] VB&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;バージョン：[vb-version](/vb-version/conversion)   
- [x] C#&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;バージョン：[csharp-version](/csharp-version/conversion)

## 概要

２０１９年４月３０日には天皇が退位され、翌５月１日に皇太子さまが即位、新元号が
適用される。３０年４カ月で幕を閉じることになる平成という。   
これに対し、和暦(元号)を西暦に換算するときの計算が面倒。このリポジトリは和暦(全元号)と
西暦の双方向変換をサポートする簡単な方法（新元号・德仁（暫定）を含む）。


## 機能

``` lua
wareki-seireki-hennkou
    +
    |
    +--java-version
    |      |
    |      +--jp.sekito.conversion
    |             |
    |             +--Seireki2WarekiConversion.java（西暦から和暦に変更するクラス）
    |             |      |
    |             |      + -- 日付形式(西暦)が正しいかどうかを判断する  checkDate()
    |             |      + -- 期日を変えることができるかどうかを判断する  isDate()
    |             |      + -- 西暦から和暦に変更する  warekiConversionApater()
    |             |
    |             +--Wareki2SeirekiConversion.java（和暦から西暦に変更するクラス）
    |                    |
    |                    + -- 日付形式(和暦)が正しいかどうかを判断する  checkDate()
    |                    + -- 和暦から西暦に変更する  seirekiConversionApater()
    |                    + -- 和暦変換(元年)  WarekigannenConversionMain()
    |                    + -- 期日を変えることができるかどうかを判断する  isDate()
    |                    + -- どの和暦か数値で取得する  warekiCheck()
    |                    + -- 和暦存在チェック warekiExistenceCheck()
    |                    + -- 和暦存在チェック（元年）warekiGannenExistenceCheck()
    |
    +--csharp-version
    |
    +--vb-version
```


## 変換する方法

年号の区間：   
明治：1868年01月01日 ～ 1912年07月29日   
大正：1912年07月30日 ～ 1926年12月24日   
昭和：1926年12月25日 ～ 1989年01月07日   
平成：1989年01月08日 ～ 2019年04月30日   
德仁：1989年05月01日 ～


### 西暦から和暦に変換する方法

【和暦への変換式】   
*（西暦 → 新元号・德仁（暫定）） "德仁" = "西暦" – 2019   
*（西暦 → 平成） "平成" = "西暦" – 1988   
*（西暦 → 昭和） "昭和" = "西暦" – 1925   
*（西暦 → 大正） "大正" = "西暦" – 1911   
*（西暦 → 明治） "明治" = "西暦" – 1867   


### 和暦から西暦に変換する方法

【西暦への変換式】   
*（德仁 → 西暦） "西暦" = "德仁" + 2019   
*（平成 → 西暦） "西暦" = "平成" + 1988   
*（昭和 → 西暦） "西暦" = "昭和" + 1925   
*（大正 → 西暦） "西暦" = "大正" + 1911   
*（明治 → 西暦） "西暦" = "明治" + 1867   



### 和暦・西暦へのフォーマット

西暦から和暦へ   

入力：yyyy/MM/dd、yyyy/M/d   
出力：〇〇年MM年dd月、〇〇年M月d

![](doc/source/images/output01.png)


和暦から西暦へ   

入力：〇〇年MM年dd月、〇〇年M月d   
出力：yyyy/MM/dd、yyyy/M/d

![](doc/source/images/output02.png)


### VBバージョンの出力図
![](doc/source/images/vb-output01.png)


## ライセンス

Licensed under the [MIT](LICENSE) License.


## 作者

bluetata / <sekito.lv@gmail.com>
