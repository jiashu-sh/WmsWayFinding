# A*简单寻路算法以及wms地图模块

整个项目基于C#，“Ai/WayfindingAStart.cs” （应该是AStar手误了，算了也懒得改类名了）是A*算法的核心类，其他是一些winform窗体之类的，为了能展示寻路过程，做了LocationMgt/FormLaneMgt.cs 这个窗体。

整个项目比较简单，主要是将整个form分为若干个方格，可以右键添加障碍（不可走）、设置起点和终点，开始运行后即绘制寻路轨迹。

界面如下：
![github](
https://upload-images.jianshu.io/upload_images/24193214-d8b74d18a5abb3ae.PNG?imageMogr2/auto-orient/strip|imageView2/2/w/1188/format/webp
"github")