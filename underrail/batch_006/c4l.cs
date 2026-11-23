using System;
using System.Collections.Generic;

// Token: 0x020005DD RID: 1501
public sealed class c4l : ce8
{
	// Token: 0x0600278F RID: 10127 RVA: 0x000E5E48 File Offset: 0x000E4048
	public override string[] c6()
	{
		return new string[]
		{
			"listCommands",
			"list",
			"lst"
		};
	}

	// Token: 0x06002791 RID: 10129 RVA: 0x000E5E74 File Offset: 0x000E4074
	public override lu c7(List<object> A_0)
	{
		List<ce8> list = bdg.e();
		bool flag = true;
		string text = "All available commands: ";
		foreach (ce8 ce in list)
		{
			if (!flag)
			{
				text += " // ";
			}
			text += string.Format("[cmd]{0}[/cmd]", ce.a());
			flag = false;
		}
		base.a(text, new object[0]);
		return null;
	}
}
