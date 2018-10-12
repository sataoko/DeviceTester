<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="/">
<html>
<style>
table {border:none;}
td,th {font-family:verdana; padding:10px;border:none;}
</style>
<body>
  <h2>LOGS</h2>
  <table border="1">
    <tr bgcolor="#F2F2f2">
      <th style="text-align:left">LOG TIME</th>
      <th style="text-align:left">INSTRUCTION</th>
	  <th style="text-align:left">DATA IN HEX</th>
	  <th style="text-align:left">DATA IN ASCII</th>
    </tr>
    <xsl:for-each select="logs/log">
    <tr>
      <td bgcolor="#E7E7E7"><xsl:value-of select="datetime"/></td>
      <td bgcolor="#E7F7f7"><xsl:value-of select="Instruction"/></td>
	  <td bgcolor="#F7F7E7"><xsl:value-of select="ReceivedDataInHEX"/></td>
	  <td bgcolor="#F7E7E7"><xsl:value-of select="ReceivedDataInASCII"/></td>
    </tr>
    </xsl:for-each>
  </table>
</body>
</html>
</xsl:template>
</xsl:stylesheet>

