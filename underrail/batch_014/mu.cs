using System;
using System.ComponentModel;
using System.Runtime.Serialization;

// Token: 0x0200018B RID: 395
[eiz("CA1")]
[TypeConverter(typeof(bf7))]
[Serializable]
public sealed class mu : ISerializable
{
	// Token: 0x06000BB1 RID: 2993 RVA: 0x0002FB98 File Offset: 0x0002DD98
	private mu(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			this.a = A_0.GetBoolean("CA1:T");
			this.b = A_0.GetBoolean("CA1:B");
			this.c = A_0.GetBoolean("CA1:L");
			this.d = A_0.GetBoolean("CA1:R");
			return;
		}
		if (base.GetType() == typeof(mu))
		{
			this.a = A_0.GetBoolean("_Top");
			this.b = A_0.GetBoolean("_Bottom");
			this.c = A_0.GetBoolean("_Left");
			this.d = A_0.GetBoolean("_Right");
			return;
		}
		this.a = A_0.GetBoolean("ControlAnchoring+_Top");
		this.b = A_0.GetBoolean("ControlAnchoring+_Bottom");
		this.c = A_0.GetBoolean("ControlAnchoring+_Left");
		this.d = A_0.GetBoolean("ControlAnchoring+_Right");
	}

	// Token: 0x06000BB2 RID: 2994 RVA: 0x0002FCA0 File Offset: 0x0002DEA0
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("CA1:T", this.a);
		info.AddValue("CA1:B", this.b);
		info.AddValue("CA1:L", this.c);
		info.AddValue("CA1:R", this.d);
	}

	// Token: 0x06000BB3 RID: 2995 RVA: 0x0002FCF4 File Offset: 0x0002DEF4
	public mu()
	{
	}

	// Token: 0x06000BB4 RID: 2996 RVA: 0x0002FCFC File Offset: 0x0002DEFC
	public mu(bool A_0, bool A_1, bool A_2, bool A_3)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
		this.d = A_3;
	}

	// Token: 0x06000BB5 RID: 2997 RVA: 0x0002FD24 File Offset: 0x0002DF24
	public bool c()
	{
		return this.a;
	}

	// Token: 0x06000BB6 RID: 2998 RVA: 0x0002FD2C File Offset: 0x0002DF2C
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000BB7 RID: 2999 RVA: 0x0002FD38 File Offset: 0x0002DF38
	public bool d()
	{
		return this.b;
	}

	// Token: 0x06000BB8 RID: 3000 RVA: 0x0002FD40 File Offset: 0x0002DF40
	public void d(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06000BB9 RID: 3001 RVA: 0x0002FD4C File Offset: 0x0002DF4C
	public bool a()
	{
		return this.c;
	}

	// Token: 0x06000BBA RID: 3002 RVA: 0x0002FD54 File Offset: 0x0002DF54
	public void c(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06000BBB RID: 3003 RVA: 0x0002FD60 File Offset: 0x0002DF60
	public bool b()
	{
		return this.d;
	}

	// Token: 0x06000BBC RID: 3004 RVA: 0x0002FD68 File Offset: 0x0002DF68
	public void b(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06000BBD RID: 3005 RVA: 0x0002FD74 File Offset: 0x0002DF74
	public override string ToString()
	{
		string text = "";
		bool flag = true;
		if (this.a)
		{
			if (!flag)
			{
				text += ", ";
			}
			text += "Top";
			flag = false;
		}
		if (this.b)
		{
			if (!flag)
			{
				text += ", ";
			}
			text += "Bottom";
			flag = false;
		}
		if (this.c)
		{
			if (!flag)
			{
				text += ", ";
			}
			text += "Left";
			flag = false;
		}
		if (this.d)
		{
			if (!flag)
			{
				text += ", ";
			}
			text += "Right";
		}
		if (string.IsNullOrEmpty(text))
		{
			return "None";
		}
		return text;
	}

	// Token: 0x06000BBE RID: 3006 RVA: 0x0002FE48 File Offset: 0x0002E048
	public static object a(string A_0)
	{
		czh.a(A_0, "str");
		mu mu = new mu();
		string[] array = A_0.Split(new char[]
		{
			','
		}, StringSplitOptions.RemoveEmptyEntries);
		for (int i = 0; i < array.Length; i++)
		{
			string text = array[i].Trim().ToUpperInvariant();
			if (!(text == "TOP"))
			{
				if (!(text == "BOTTOM"))
				{
					if (!(text == "LEFT"))
					{
						if (text == "RIGHT")
						{
							mu.b(true);
						}
					}
					else
					{
						mu.c(true);
					}
				}
				else
				{
					mu.d(true);
				}
			}
			else
			{
				mu.a(true);
			}
		}
		return mu;
	}

	// Token: 0x040006E8 RID: 1768
	private bool a;

	// Token: 0x040006E9 RID: 1769
	private bool b;

	// Token: 0x040006EA RID: 1770
	private bool c;

	// Token: 0x040006EB RID: 1771
	private bool d;
}
