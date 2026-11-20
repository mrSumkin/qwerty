using System;
using System.Collections.Generic;

// Token: 0x020005C9 RID: 1481
public abstract class ce8
{
	// Token: 0x17000113 RID: 275
	// (get) Token: 0x0600274C RID: 10060
	public abstract string[] Commands { get; }

	// Token: 0x17000114 RID: 276
	// (get) Token: 0x0600274D RID: 10061 RVA: 0x000E4610 File Offset: 0x000E2810
	public List<ayk> Args
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x0600274E RID: 10062
	public abstract lu c7(List<object> A_0);

	// Token: 0x0600274F RID: 10063 RVA: 0x000E4618 File Offset: 0x000E2818
	public virtual void wu(List<object> A_0, object A_1)
	{
	}

	// Token: 0x06002750 RID: 10064 RVA: 0x000E461C File Offset: 0x000E281C
	protected void a(string A_0, params object[] A_1)
	{
		bdg.a(A_0, A_1);
	}

	// Token: 0x06002751 RID: 10065 RVA: 0x000E4628 File Offset: 0x000E2828
	protected virtual string d()
	{
		string text = string.Format("Usage: [cmd]{0}[/cmd]", this.a());
		if (this.a != null && this.a.Count > 0)
		{
			text += "[param]";
			foreach (ayk ayk in this.a)
			{
				string str;
				if (ayk.c != null)
				{
					str = ayk.c;
				}
				else
				{
					ae1 ae = bdg.a(ayk.a);
					if (ae != null)
					{
						str = ae.gr();
					}
					else
					{
						str = "arg";
					}
				}
				if (ayk.b)
				{
					text = text + " <" + str + ">";
				}
				else
				{
					text = text + " (" + str + ")";
				}
			}
			text += "[/param]";
		}
		return text;
	}

	// Token: 0x06002752 RID: 10066 RVA: 0x000E4738 File Offset: 0x000E2938
	public void b()
	{
		bdg.a(this.d(), new object[0]);
	}

	// Token: 0x06002753 RID: 10067 RVA: 0x000E474C File Offset: 0x000E294C
	public string a()
	{
		bool flag = true;
		string text = "";
		foreach (string str in this.Commands)
		{
			if (!flag)
			{
				text += " | ";
			}
			flag = false;
			text += str;
		}
		return text;
	}

	// Token: 0x0400163E RID: 5694
	private List<ayk> a = new List<ayk>();
}
