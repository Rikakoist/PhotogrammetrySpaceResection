# PhotogrammetrySpaceResection
摄影测量学空间后方交会计算程序。<br>
本程序使用的用户界面主题为 [CSkin](http://www.cskin.net/ "CSkin官网")<br>
使用的矩阵运算类来自 https://github.com/YanjieHe/MatrixLibrary
## 用户界面及其使用
程序界面分为上、下两块区域。<br>
上半部分为数据输入区域，用户可手动输入、编辑点位信息，也可点击“读取数据”按钮，从数据文件中读取点位数据。<br>
下半部分为数据管理区域，用户可更改数据文件的存取位置、打开目标文件夹、存储计算结果、输入除点位外的已知条件等。<br>
最右侧为计算结果显示框，在用户点击“计算”按钮后将会显示交会结果。 
## 测试数据

<table>
    <tr>
        <th rowspan = "2">点号</th>
        <th colspan = "2">像点坐标</th>
        <th colspan = "3">地面坐标</th>
    </tr>
    <tr>
        <td>𝑥 (𝑚𝑚)</td>
        <td>𝑦 (𝑚𝑚)</td>
		    <td>𝑋 (𝑚𝑚)</td>
		    <td>𝑌 (𝑚𝑚)</td>
		    <td>𝑍 (𝑚𝑚)</td>
    </tr>
    <tr>
        <td>1</td>
        <td>-86.15</td>
		    <td>-68.99</td>
		    <td>36589.41</td>
		    <td>25273.32</td>
		    <td>2195.17</td>
    </tr>
	    <tr>
        <td>2</td>
        <td>-53.40</td>
		    <td>82.21</td>
		    <td>37631.08</td>
		    <td>31324.51</td>
		    <td>728.69</td>
    </tr>
    <tr>
        <td>3</td>
        <td>-14.78</td>
		    <td>-76.63</td>
		    <td>39100.97</td>
		    <td>24934.98</td>
		    <td>2386.50</td>
    </tr>
    <tr>
        <td>4</td>
        <td>10.46</td>
		    <td>64.43</td>
		    <td>40426.54</td>
		    <td>30319.81</td>
		    <td>757.31</td>
    </tr>
</table>

内方位元素：𝑓 = 153.24mm，𝑥0 = 0.01mm，𝑦0 = −0.02mm，像片比例尺：1:40000。
