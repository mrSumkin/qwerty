using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;

// Token: 0x0200128C RID: 4748
[eiz("DBPEA")]
[Serializable]
public sealed class cua : Aspect<c5x>, bp1, c98
{
	// Token: 0x0600674D RID: 26445 RVA: 0x002BCD54 File Offset: 0x002BAF54
	private cua(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("DBPEA:B");
		this.b = A_0.GetBoolean("DBPEA:T");
		this.c = A_0.GetDouble("DBPEA:I");
	}

	// Token: 0x0600674E RID: 26446 RVA: 0x002BCD9C File Offset: 0x002BAF9C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DBPEA:B", this.a);
		info.AddValue("DBPEA:T", this.b);
		info.AddValue("DBPEA:I", this.c);
	}

	// Token: 0x0600674F RID: 26447 RVA: 0x002BCDE4 File Offset: 0x002BAFE4
	public string e()
	{
		return this.a;
	}

	// Token: 0x06006750 RID: 26448 RVA: 0x002BCDEC File Offset: 0x002BAFEC
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006751 RID: 26449 RVA: 0x002BCDF8 File Offset: 0x002BAFF8
	public bool d()
	{
		return this.b;
	}

	// Token: 0x06006752 RID: 26450 RVA: 0x002BCE00 File Offset: 0x002BB000
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006753 RID: 26451 RVA: 0x002BCE0C File Offset: 0x002BB00C
	public cua(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006754 RID: 26452 RVA: 0x002BCE18 File Offset: 0x002BB018
	public void mx()
	{
		this.a();
	}

	// Token: 0x06006755 RID: 26453 RVA: 0x002BCE20 File Offset: 0x002BB020
	public void my()
	{
	}

	// Token: 0x06006756 RID: 26454 RVA: 0x002BCE28 File Offset: 0x002BB028
	public void r7(eds A_0)
	{
		if ((this.c -= A_0.b.TotalMilliseconds) <= 0.0)
		{
			this.c = 250.0 + cuo.a.NextDouble() * 250.0;
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && base.a8() != null && base.a8().j == cgy.b && base.a8().Area != null && base.a8().c(dm9.b))
			{
				string name = this.b();
				if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>(name, new bool?(false)).Value)
				{
					d60 d = base.a8().Zone.a();
					if (d != null)
					{
						List<b0b> list = d.ab4(new string[]
						{
							bp5.j + this.a
						});
						if (list != null)
						{
							foreach (b0b b0b in list)
							{
								cua aspect = b0b.GetAspect<cua>();
								if (aspect != null)
								{
									foreach (ak1 ak in b0b.l)
									{
										if (aspect.b)
										{
											ak.a(dm9.a);
										}
										else
										{
											ak.a(dm9.a, b0b);
										}
									}
									b0b.RemoveAspect<cua>();
								}
							}
						}
						serviceOrThrow.aqu().r()[name] = true;
						return;
					}
				}
				else
				{
					base.a8().RemoveAspect<cua>();
				}
			}
		}
	}

	// Token: 0x06006757 RID: 26455 RVA: 0x002BD034 File Offset: 0x002BB234
	private string b()
	{
		return bp5.j + base.a8().Zone.y8() + "_" + this.a;
	}

	// Token: 0x06006758 RID: 26456 RVA: 0x002BD068 File Offset: 0x002BB268
	private void a()
	{
		e3l e3l = base.a8().GetAspect<e3l>();
		if (e3l == null)
		{
			e3l = new e3l(base.a8());
			base.a8().SetAspect<e3l>(e3l);
		}
		for (int i = e3l.a.Count - 1; i >= 0; i--)
		{
			if (e3l.a[i].StartsWith(bp5.j))
			{
				e3l.a.RemoveAt(i);
			}
		}
		e3l.a.Add(bp5.j + this.a);
		e3l.a();
	}

	// Token: 0x04002ABA RID: 10938
	private string a;

	// Token: 0x04002ABB RID: 10939
	private bool b;

	// Token: 0x04002ABC RID: 10940
	private double c;
}
