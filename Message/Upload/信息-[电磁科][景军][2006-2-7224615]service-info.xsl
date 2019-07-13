<xsl:stylesheet xmlns:xsl="http://www.w3.org/TR/WD-xsl">
<xsl:template match="/">

<font face="Arial, Helvetica, sans-serif">
<div style="LEFT: 0px; TOP: 0px; POSITION: absolute;WIDTH: 1000px; HEIGHT: 65px; color:white; background-color:black">
</div>

<div style="LEFT: 20px; TOP: 0px; POSITION: absolute;WIDTH: 100%; HEIGHT: 65px; color:white; background-color:black">

<p >
<br />保证和部件信息</p>
</div>

<div style="TOP: 50px; WIDTH: 98%; LEFT: 20px; POSITION: absolute; ">


<br />
<h3>保证信息</h3>

<xsl:for-each select="output/warrantyInfo/machine">
<p>
<table border="1" width="100%">
<tr><td width="20%">机器类型和型号：</td><td><xsl:value-of select="type" /> - <xsl:value-of select="model" /></td></tr>
<tr><td>序列号：</td><td><xsl:value-of select="serial" /></td></tr>
<tr><td>出货日期：</td><td><xsl:value-of select="shipDate" /></td></tr>
<tr><td>估计保证失效日期：</td><td ><xsl:value-of select="wed" /></td></tr>
<tr><td>保证失效描述：</td><td>IBM 的估计保证失效日期自 IBM 的“出货日期”开始计算。有关 IBM 保证的完整条款和条件，请查阅随计算机提供的印刷出版物里的“有限保证声明”或访问 IBM Machine Warranty 万维网站点（http://www.ibm.com/servers/support/machine_warranties/）以获得 IBM 机器有限保证的全球概述。</td></tr>
</table>
</p>
</xsl:for-each>


<h3>服务部件信息</h3>
<p>现场可更换件（FRU）是技术人员通常替换的计算机部件。然而有些 FRU 也可由客户替换。这些部件被视为客户可更换件（CRU），包含如键盘、鼠标、扬声器、内存、硬盘驱动器或其它易于更换的部件。IBM 会把 CRU 送给您以便您可以在自己方便的时候更换。下表列出计算机的公共 FRU 并包含“部件号”和“描述”。</p>
<table border="1" width="100%">
<tr><td>FRU 部件号 </td><td>FRU 描述 </td> </tr>
<xsl:for-each select="output/warrantyInfo/part">

<tr>
	<xsl:choose>
		<xsl:when test="fruPart[.='0000000']">
			<td>  </td>
		</xsl:when>
		<xsl:otherwise>
			<td><xsl:value-of select="fruPart" /></td>
		</xsl:otherwise>
	</xsl:choose>

	<td><xsl:value-of select="fruDesc" /></td>
</tr>

</xsl:for-each>
</table>
<br />
</div>
</font>

</xsl:template>
</xsl:stylesheet>

