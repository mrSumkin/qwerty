using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Ouroboros.Core.Logging;
using TimelapseVertigo.Generators.Items;

// Token: 0x0200071A RID: 1818
[eiz("IO")]
[Serializable]
public sealed class xs : ISerializable
{
	// Token: 0x06002F2F RID: 12079 RVA: 0x0011E204 File Offset: 0x0011C404
	private xs(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (aw4)A_0.GetValue("IO:G", typeof(aw4));
			this.b = A_0.GetSingle("IO:C");
			this.c = A_0.GetInt32("IO:SG");
			this.d = (AutoEquipMode)A_0.GetValue("IO:AEM", typeof(AutoEquipMode));
			this.e = A_0.GetBoolean("IO:L");
			this.g = A_0.GetInt32("IO:A");
			if (ell.a() >= 7)
			{
				this.f = A_0.GetBoolean("IO:S");
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(xs))
			{
				this.a = (aw4)A_0.GetValue("_Generator", typeof(aw4));
				this.b = A_0.GetSingle("_Chance");
				this.c = A_0.GetInt32("_SubGroup");
				this.d = (AutoEquipMode)A_0.GetValue("_AutoEquipMode", typeof(AutoEquipMode));
				this.e = A_0.GetBoolean("_Lootable");
				this.g = A_0.GetInt32("_Amount");
				return;
			}
			this.a = (aw4)A_0.GetValue("ItemOpportunity+_Generator", typeof(aw4));
			this.b = A_0.GetSingle("ItemOpportunity+_Chance");
			this.c = A_0.GetInt32("ItemOpportunity+_SubGroup");
			this.d = (AutoEquipMode)A_0.GetValue("ItemOpportunity+_AutoEquipMode", typeof(AutoEquipMode));
			this.e = A_0.GetBoolean("ItemOpportunity+_Lootable");
			this.g = A_0.GetInt32("ItemOpportunity+_Amount");
		}
	}

	// Token: 0x06002F30 RID: 12080 RVA: 0x0011E408 File Offset: 0x0011C608
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("IO:G", this.a);
		info.AddValue("IO:C", this.b);
		info.AddValue("IO:SG", this.c);
		info.AddValue("IO:AEM", this.d);
		info.AddValue("IO:L", this.e);
		info.AddValue("IO:S", this.f);
		info.AddValue("IO:A", this.g);
	}

	// Token: 0x17000184 RID: 388
	// (get) Token: 0x06002F31 RID: 12081 RVA: 0x0011E494 File Offset: 0x0011C694
	// (set) Token: 0x06002F32 RID: 12082 RVA: 0x0011E49C File Offset: 0x0011C69C
	[Browsable(false)]
	public aw4 Generator
	{
		get
		{
			return this.a;
		}
		set
		{
			this.a = value;
		}
	}

	// Token: 0x17000185 RID: 389
	// (get) Token: 0x06002F33 RID: 12083 RVA: 0x0011E4A8 File Offset: 0x0011C6A8
	// (set) Token: 0x06002F34 RID: 12084 RVA: 0x0011E4B0 File Offset: 0x0011C6B0
	public float Chance
	{
		get
		{
			return this.b;
		}
		set
		{
			this.b = value;
		}
	}

	// Token: 0x17000186 RID: 390
	// (get) Token: 0x06002F35 RID: 12085 RVA: 0x0011E4BC File Offset: 0x0011C6BC
	// (set) Token: 0x06002F36 RID: 12086 RVA: 0x0011E4C4 File Offset: 0x0011C6C4
	public int SubGroup
	{
		get
		{
			return this.c;
		}
		set
		{
			this.c = value;
		}
	}

	// Token: 0x17000187 RID: 391
	// (get) Token: 0x06002F37 RID: 12087 RVA: 0x0011E4D0 File Offset: 0x0011C6D0
	// (set) Token: 0x06002F38 RID: 12088 RVA: 0x0011E4D8 File Offset: 0x0011C6D8
	public AutoEquipMode AutoEquipMode
	{
		get
		{
			return this.d;
		}
		set
		{
			this.d = value;
		}
	}

	// Token: 0x17000188 RID: 392
	// (get) Token: 0x06002F39 RID: 12089 RVA: 0x0011E4E4 File Offset: 0x0011C6E4
	// (set) Token: 0x06002F3A RID: 12090 RVA: 0x0011E4EC File Offset: 0x0011C6EC
	public bool Lootable
	{
		get
		{
			return this.e;
		}
		set
		{
			this.e = value;
		}
	}

	// Token: 0x17000189 RID: 393
	// (get) Token: 0x06002F3B RID: 12091 RVA: 0x0011E4F8 File Offset: 0x0011C6F8
	// (set) Token: 0x06002F3C RID: 12092 RVA: 0x0011E500 File Offset: 0x0011C700
	public bool Stealable
	{
		get
		{
			return this.f;
		}
		set
		{
			this.f = value;
		}
	}

	// Token: 0x1700018A RID: 394
	// (get) Token: 0x06002F3D RID: 12093 RVA: 0x0011E50C File Offset: 0x0011C70C
	// (set) Token: 0x06002F3E RID: 12094 RVA: 0x0011E514 File Offset: 0x0011C714
	public int Amount
	{
		get
		{
			return this.g;
		}
		set
		{
			this.g = value;
		}
	}

	// Token: 0x06002F3F RID: 12095 RVA: 0x0011E520 File Offset: 0x0011C720
	public xs()
	{
	}

	// Token: 0x06002F40 RID: 12096 RVA: 0x0011E548 File Offset: 0x0011C748
	public override string ToString()
	{
		string text;
		if (this.a != null)
		{
			text = this.a.ToString();
		}
		else
		{
			text = "<null generator>";
		}
		return string.Concat(new string[]
		{
			text,
			" - подгруппа ",
			this.c.ToString(),
			" : ",
			(this.b * 100f).ToString(),
			"% : Auto-equip mode: ",
			this.d.ToString()
		});
	}

	// Token: 0x06002F41 RID: 12097 RVA: 0x0011E5D8 File Offset: 0x0011C7D8
	public List<bmd> a(int? A_0, int? A_1, bool? A_2, bool? A_3)
	{
		List<bmd> list = this.a(false, A_0, A_1, A_2, A_3);
		this.b(list);
		return list;
	}

	// Token: 0x06002F42 RID: 12098 RVA: 0x0011E5FC File Offset: 0x0011C7FC
	public List<bmd> a(bool A_0, int? A_1, int? A_2, bool? A_3, bool? A_4)
	{
		List<bmd> list = new List<bmd>();
		for (int i = 0; i < this.g; i++)
		{
			if (A_0 || zp.a.NextDouble() < (double)this.b)
			{
				try
				{
					aw4 aw = this.a.a1();
					if (aw.nd() == null)
					{
						aw.ne(A_1);
					}
					if (aw.nf() == null)
					{
						aw.ng(A_2);
					}
					if (aw.nh() == null)
					{
						aw.ni(A_3);
					}
					if (aw.nj() == null)
					{
						aw.nk(A_4);
					}
					List<coh> list2 = aw.np();
					if (list != null)
					{
						foreach (coh a_ in list2)
						{
							list.Add(new bmd(a_, this.d));
						}
					}
				}
				catch (Exception a_2)
				{
					dux.a(LogSeverity.Error, a_2, "Failed to generate item from item opportunity '{0}'.", new object[]
					{
						this.ToString()
					});
				}
			}
		}
		xs.a(list);
		this.b(list);
		return list;
	}

	// Token: 0x06002F43 RID: 12099 RVA: 0x0011E764 File Offset: 0x0011C964
	public xs g()
	{
		return new xs
		{
			d = this.d,
			b = this.b,
			e = this.e,
			f = this.f,
			c = this.c,
			a = ((this.a != null) ? this.a.a1() : null),
			g = this.g
		};
	}

	// Token: 0x06002F44 RID: 12100 RVA: 0x0011E7E0 File Offset: 0x0011C9E0
	private void b(List<bmd> A_0)
	{
		if (A_0 != null)
		{
			foreach (bmd bmd in A_0)
			{
				if (bmd.Item != null)
				{
					bmd.Item.Stealable = this.f;
					bmd.Item.Lootable = this.e;
				}
			}
		}
	}

	// Token: 0x06002F45 RID: 12101 RVA: 0x0011E860 File Offset: 0x0011CA60
	private static void a(List<bmd> A_0)
	{
		if (A_0.Count > 1)
		{
			for (int i = A_0.Count - 1; i >= 0; i--)
			{
				bmd bmd = A_0[i];
				if (bmd.Item != null && bmd.Item.Definition.a5() != null && bmd.Item.Definition.be() > 1)
				{
					for (int j = i - 1; j >= 0; j--)
					{
						bmd bmd2 = A_0[j];
						if (bmd2.Item != null && bmd2.Item.Definition.be() > 1 && bmd2.Item.Definition.a5() == bmd.Item.Definition.a5() && bmd2.Item.Stacks < bmd2.Item.Definition.be())
						{
							int num = Math.Min(bmd2.Item.Definition.be() - bmd2.Item.Stacks, bmd.Item.Stacks);
							bmd2.Item.Stacks += num;
							bmd.Item.Stacks -= num;
							if (bmd.Item.Stacks <= 0)
							{
								A_0.RemoveAt(i);
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x04001A21 RID: 6689
	private aw4 a;

	// Token: 0x04001A22 RID: 6690
	private float b = 1f;

	// Token: 0x04001A23 RID: 6691
	private int c;

	// Token: 0x04001A24 RID: 6692
	private AutoEquipMode d;

	// Token: 0x04001A25 RID: 6693
	private bool e = true;

	// Token: 0x04001A26 RID: 6694
	private bool f = true;

	// Token: 0x04001A27 RID: 6695
	private int g = 1;
}
