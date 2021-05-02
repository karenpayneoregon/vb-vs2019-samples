# About 

These converters are required for readin computer details in [this method](https://github.com/karenpayneoregon/vb-vs2019-samples/blob/Branch1/PowerShellGetTimeZoneDetailsNet5/Operations.vb#L42) written with VB.NET

These converters assist with the VB.NET frontend code as per below from Microsoft.

<table>
	<tr>
		<td>
			Parts of System.Text.Json use <a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/struct#ref-struct">ref structs</a> , which are not supported by Visual Basic. If you try to use System.Text.Json ref struct APIs with Visual Basic you get BC40000 compiler errors. The error message indicates that the problem is an obsolete API, but the actual issue is lack of ref struct support in the compiler. The following parts of System.Text.Json aren't usable from Visual Basic:
		</td>
	</tr>
</table>