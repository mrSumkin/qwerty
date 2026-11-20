using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;

// Token: 0x0200128F RID: 4751
[eiz("PBGCEA")]
[Serializable]
public sealed class bv6 : Aspect<c5x>, ISerializable, c98
{
	// Token: 0x06006773 RID: 26483 RVA: 0x002BDD44 File Offset: 0x002BBF44
	private bv6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetBoolean("PBGCEA:E");
		this.c = A_0.GetDouble("PBGCEA:C");
		this.d = A_0.GetDouble("PBGCEA:T");
		this.e = A_0.GetBoolean("PBGCEA:P");
		this.f = A_0.GetString("PBGCEA:R");
		this.g = (Guid)A_0.GetValue("PBGCEA:I", typeof(Guid));
		this.h = A_0.GetString("PBGCEA:A");
		this.i = A_0.GetInt32("PBGCEA:D");
		di7.ReadList<cze>("PBGCEA:J", ref this.j, A_0);
		if (ell.a() >= 479)
		{
			this.k = A_0.GetBoolean("PBGCEA:N");
		}
		if (ell.a() >= 480)
		{
			this.l = A_0.GetBoolean("PBGCEA:S");
			this.m = A_0.GetString("PBGCEA:G");
		}
	}

	// Token: 0x06006774 RID: 26484 RVA: 0x002BDE60 File Offset: 0x002BC060
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PBGCEA:E", this.b);
		info.AddValue("PBGCEA:C", this.c);
		info.AddValue("PBGCEA:T", this.d);
		info.AddValue("PBGCEA:P", this.e);
		info.AddValue("PBGCEA:R", this.f);
		info.AddValue("PBGCEA:I", this.g);
		info.AddValue("PBGCEA:A", this.h);
		info.AddValue("PBGCEA:D", this.i);
		di7.WriteList<cze>("PBGCEA:J", this.j, info);
		info.AddValue("PBGCEA:N", this.k);
		info.AddValue("PBGCEA:S", this.l);
		info.AddValue("PBGCEA:G", this.m);
	}

	// Token: 0x06006775 RID: 26485 RVA: 0x002BDF48 File Offset: 0x002BC148
	public bool k()
	{
		return this.b;
	}

	// Token: 0x06006776 RID: 26486 RVA: 0x002BDF50 File Offset: 0x002BC150
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006777 RID: 26487 RVA: 0x002BDF5C File Offset: 0x002BC15C
	public bool h()
	{
		return this.e;
	}

	// Token: 0x06006778 RID: 26488 RVA: 0x002BDF64 File Offset: 0x002BC164
	public void b(bool A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06006779 RID: 26489 RVA: 0x002BDF70 File Offset: 0x002BC170
	public string f()
	{
		return this.f;
	}

	// Token: 0x0600677A RID: 26490 RVA: 0x002BDF78 File Offset: 0x002BC178
	public void b(string A_0)
	{
		this.f = A_0;
	}

	// Token: 0x0600677B RID: 26491 RVA: 0x002BDF84 File Offset: 0x002BC184
	public Guid g()
	{
		return this.g;
	}

	// Token: 0x0600677C RID: 26492 RVA: 0x002BDF8C File Offset: 0x002BC18C
	public void a(Guid A_0)
	{
		this.g = A_0;
	}

	// Token: 0x0600677D RID: 26493 RVA: 0x002BDF98 File Offset: 0x002BC198
	public string b()
	{
		return this.h;
	}

	// Token: 0x0600677E RID: 26494 RVA: 0x002BDFA0 File Offset: 0x002BC1A0
	public void c(string A_0)
	{
		this.h = A_0;
	}

	// Token: 0x0600677F RID: 26495 RVA: 0x002BDFAC File Offset: 0x002BC1AC
	public int e()
	{
		return this.i;
	}

	// Token: 0x06006780 RID: 26496 RVA: 0x002BDFB4 File Offset: 0x002BC1B4
	public void a(int A_0)
	{
		this.i = A_0;
	}

	// Token: 0x06006781 RID: 26497 RVA: 0x002BDFC0 File Offset: 0x002BC1C0
	public List<cze> d()
	{
		return this.j;
	}

	// Token: 0x06006782 RID: 26498 RVA: 0x002BDFC8 File Offset: 0x002BC1C8
	public void a(List<cze> A_0)
	{
		this.j = A_0;
	}

	// Token: 0x06006783 RID: 26499 RVA: 0x002BDFD4 File Offset: 0x002BC1D4
	public string i()
	{
		return this.m;
	}

	// Token: 0x06006784 RID: 26500 RVA: 0x002BDFDC File Offset: 0x002BC1DC
	public void a(string A_0)
	{
		this.m = A_0;
	}

	// Token: 0x06006785 RID: 26501 RVA: 0x002BDFE8 File Offset: 0x002BC1E8
	public bool j()
	{
		return this.l;
	}

	// Token: 0x06006786 RID: 26502 RVA: 0x002BDFF0 File Offset: 0x002BC1F0
	public void c(bool A_0)
	{
		this.l = A_0;
	}

	// Token: 0x06006787 RID: 26503 RVA: 0x002BDFFC File Offset: 0x002BC1FC
	public bv6(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006788 RID: 26504 RVA: 0x002BE014 File Offset: 0x002BC214
	public void r7(eds A_0)
	{
		if (this.d != 0.0 && (this.d -= A_0.b.TotalMilliseconds) < 0.0)
		{
			this.d = 0.0;
		}
		if ((this.c += A_0.b.TotalMilliseconds) >= (double)bv6.a)
		{
			this.c -= (double)bv6.a;
			this.a();
		}
	}

	// Token: 0x06006789 RID: 26505 RVA: 0x002BE0AC File Offset: 0x002BC2AC
	private void a()
	{
		if (base.a8() != null && base.a8().Zone != null)
		{
			aud aud;
			if (!string.IsNullOrEmpty(this.h))
			{
				aud = base.a8().Zone.n(this.h);
			}
			else
			{
				aud = base.a8().Area;
			}
			if (aud != null)
			{
				c5x c5x = new ar7(this.g, aud).ao() as c5x;
				if (c5x != null)
				{
					d60 d = base.a8().Zone.a();
					if (d != null)
					{
						List<bm6> list = new List<bm6>();
						foreach (b0b b0b in d.ab4(new string[]
						{
							this.f
						}))
						{
							amc aspect = b0b.GetAspect<amc>();
							bm6 aspect2 = b0b.GetAspect<bm6>();
							if (aspect != null && aspect2 != null && !aspect.aa().Dead)
							{
								List<d0h> classPropertyValue = aspect2.y6().GetClassPropertyValue<List<d0h>>(ddq.bl);
								if (classPropertyValue != null && classPropertyValue.Count > 0)
								{
									foreach (d0h d0h in classPropertyValue)
									{
										if (d0h.a == this.g && d0h.b == aud.y8())
										{
											d0h.d = this.m;
											this.d = (double)this.i;
											return;
										}
									}
								}
								list.Add(aspect2);
							}
						}
						if (list.Count > 0)
						{
							bm6 bm = null;
							if (this.l)
							{
								foreach (bm6 bm2 in list)
								{
									List<d0h> classPropertyValue2 = bm2.y6().GetClassPropertyValue<List<d0h>>(ddq.bl);
									if (classPropertyValue2 != null && classPropertyValue2.Count > 0)
									{
										bm = bm2;
										break;
									}
								}
							}
							if (bm == null)
							{
								if (this.e && list.Count > 1)
								{
									double num = double.MaxValue;
									bm6 bm3 = null;
									foreach (bm6 bm4 in list)
									{
										double num2 = aw1.b(bm4.a8(), c5x);
										if (bm4.a8().Area != c5x.Area)
										{
											num2 += 300.0;
										}
										if (bm3 == null || num2 < num)
										{
											num = num2;
											bm3 = bm4;
										}
									}
									bm = bm3;
								}
								else
								{
									bm = list[cuo.a.Next(list.Count)];
								}
							}
							if (!this.k || this.d == 0.0)
							{
								this.k = true;
								this.d = (double)this.i;
								List<d0h> list2 = bm.y6().GetClassPropertyValue<List<d0h>>(ddq.bl);
								if (list2 == null)
								{
									list2 = new List<d0h>();
									bm.y6()[ddq.bl] = list2;
								}
								d0h item = new d0h(this.g, aud.y8(), this.m, false);
								list2.Add(item);
								Dictionary<string, object> a_ = new Dictionary<string, object>();
								foreach (cze cze in this.j)
								{
									cze.ym(base.a8(), bm.a8(), a_);
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x04002AC6 RID: 10950
	private static readonly int a = 2000;

	// Token: 0x04002AC7 RID: 10951
	private bool b;

	// Token: 0x04002AC8 RID: 10952
	private double c;

	// Token: 0x04002AC9 RID: 10953
	private double d;

	// Token: 0x04002ACA RID: 10954
	private bool e;

	// Token: 0x04002ACB RID: 10955
	private string f;

	// Token: 0x04002ACC RID: 10956
	private Guid g;

	// Token: 0x04002ACD RID: 10957
	private string h;

	// Token: 0x04002ACE RID: 10958
	private int i;

	// Token: 0x04002ACF RID: 10959
	private List<cze> j = new List<cze>();

	// Token: 0x04002AD0 RID: 10960
	private bool k;

	// Token: 0x04002AD1 RID: 10961
	private bool l;

	// Token: 0x04002AD2 RID: 10962
	private string m;
}
