using System;
using System.ComponentModel;
using System.Runtime.Serialization;

// Token: 0x02000092 RID: 146
[eiz("HV")]
[TypeConverter(typeof(bf7))]
[Serializable]
public sealed class cxv : ISerializable
{
	// Token: 0x0600036F RID: 879 RVA: 0x0000FED8 File Offset: 0x0000E0D8
	private cxv(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			this.a = A_0.GetBoolean("HV:H");
			this.b = A_0.GetBoolean("HV:V");
			return;
		}
		if (base.GetType() == typeof(cxv))
		{
			this.a = A_0.GetBoolean("_Horizontal");
			this.b = A_0.GetBoolean("_Vertical");
			return;
		}
		this.a = A_0.GetBoolean("HorizontalVertical+_Horizontal");
		this.b = A_0.GetBoolean("HorizontalVertical+_Vertical");
	}

	// Token: 0x06000370 RID: 880 RVA: 0x0000FF78 File Offset: 0x0000E178
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("HV:H", this.a);
		info.AddValue("HV:V", this.b);
	}

	// Token: 0x06000371 RID: 881 RVA: 0x0000FF9C File Offset: 0x0000E19C
	public bool b()
	{
		return this.a;
	}

	// Token: 0x06000372 RID: 882 RVA: 0x0000FFA4 File Offset: 0x0000E1A4
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000373 RID: 883 RVA: 0x0000FFB0 File Offset: 0x0000E1B0
	public bool a()
	{
		return this.b;
	}

	// Token: 0x06000374 RID: 884 RVA: 0x0000FFB8 File Offset: 0x0000E1B8
	public void b(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06000375 RID: 885 RVA: 0x0000FFC4 File Offset: 0x0000E1C4
	public cxv()
	{
	}

	// Token: 0x06000376 RID: 886 RVA: 0x0000FFD0 File Offset: 0x0000E1D0
	public override string ToString()
	{
		if (this.a && this.b)
		{
			return "Both";
		}
		if (!this.a && !this.b)
		{
			return "None";
		}
		if (this.a)
		{
			return "Horizontal";
		}
		return "Vertical";
	}

	// Token: 0x06000377 RID: 887 RVA: 0x0001002C File Offset: 0x0000E22C
	public static cxv a(string A_0)
	{
		czh.a(A_0, "str");
		cxv cxv = new cxv();
		string text = A_0.Trim().ToUpperInvariant();
		if (text != null)
		{
			int length = text.Length;
			if (length <= 4)
			{
				if (length != 1)
				{
					if (length != 4)
					{
						return cxv;
					}
					if (!(text == "BOTH"))
					{
						return cxv;
					}
				}
				else
				{
					char c = text[0];
					if (c <= 'B')
					{
						if (c != '*' && c != 'B')
						{
							return cxv;
						}
					}
					else
					{
						if (c == 'H')
						{
							goto IL_D1;
						}
						if (c != 'V')
						{
							return cxv;
						}
						goto IL_DD;
					}
				}
				cxv.a = true;
				cxv.b = true;
				return cxv;
			}
			if (length != 8)
			{
				if (length != 10)
				{
					return cxv;
				}
				if (!(text == "HORIZONTAL"))
				{
					return cxv;
				}
			}
			else
			{
				if (!(text == "VERTICAL"))
				{
					return cxv;
				}
				goto IL_DD;
			}
			IL_D1:
			cxv.a = true;
			return cxv;
			IL_DD:
			cxv.b = true;
		}
		return cxv;
	}

	// Token: 0x0400040D RID: 1037
	private bool a;

	// Token: 0x0400040E RID: 1038
	private bool b;
}
