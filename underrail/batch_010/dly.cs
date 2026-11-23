using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Items;

// Token: 0x020013EB RID: 5099
public sealed class dly : ay7
{
	// Token: 0x060072CD RID: 29389 RVA: 0x003049BC File Offset: 0x00302BBC
	public dly(bool A_0)
	{
		this.a = (A_0 ? "BlackArrow_rf" : "BlackArrow");
	}

	// Token: 0x060072CE RID: 29390 RVA: 0x003049E0 File Offset: 0x00302BE0
	public void pe(amc A_0, amc A_1, cd1 A_2, cwt A_3, AmmoType A_4, enp A_5 = null, Action<cwt, amc> A_6 = null)
	{
		A_0.a8().c().a(this.a);
		bool a_ = true;
		aig[] a_2 = new aig[]
		{
			new dly.a(A_0.aa().Offense.u(), A_0, A_1, A_3, A_4, null, A_6)
		};
		awq.a(A_0, A_1, A_3, A_2, A_5, a_, null, "blackArrowBullet", a_2, false, false, true, null, null);
	}

	// Token: 0x060072CF RID: 29391 RVA: 0x00304A50 File Offset: 0x00302C50
	public void ae(amc A_0, amc A_1, cd1 A_2, AmmoType A_3)
	{
	}

	// Token: 0x04002EE7 RID: 12007
	private string a;

	// Token: 0x020013ED RID: 5101
	[eiz("BABPH")]
	[Serializable]
	private sealed class a : aig, ISerializable
	{
		// Token: 0x060072D2 RID: 29394 RVA: 0x00304A54 File Offset: 0x00302C54
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.c = (A_0.GetValue("BABPH:W", typeof(cd1)) as cd1);
			this.d = (A_0.GetValue("BABPH:A", typeof(EntityAspectReference<amc, amc>)) as EntityAspectReference<amc, amc>);
			this.e = (A_0.GetValue("BABPH:P", typeof(EntityAspectReference<amc, amc>)) as EntityAspectReference<amc, amc>);
			this.f = (A_0.GetValue("BABPH:T", typeof(HashSet<Point>)) as HashSet<Point>);
			this.g = (A_0.GetValue("BABPH:E", typeof(HashSet<Guid>)) as HashSet<Guid>);
			this.b = (AmmoType)A_0.GetValue("BABPH:B", typeof(AmmoType));
			this.a = (Guid)A_0.GetValue("BABPH:S", typeof(Guid));
			this.h = (A_0.GetValue("BABPH:C", typeof(enp)) as enp);
			this.i = (A_0.GetValue("BABPH:X", typeof(Action<cwt, amc>)) as Action<cwt, amc>);
		}

		// Token: 0x060072D3 RID: 29395 RVA: 0x00304BA0 File Offset: 0x00302DA0
		public void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			info.AddValue("BABPH:W", this.c);
			info.AddValue("BABPH:A", this.d);
			info.AddValue("BABPH:P", this.e);
			info.AddValue("BABPH:T", this.f);
			info.AddValue("BABPH:E", this.g);
			info.AddValue("BABPH:B", this.b);
			info.AddValue("BABPH:S", this.a);
			info.AddValue("BABPH:C", this.h);
			info.AddValue("BABPH:X", this.i);
		}

		// Token: 0x060072D4 RID: 29396 RVA: 0x00304C50 File Offset: 0x00302E50
		public a(cd1 A_0, amc A_1, amc A_2, cwt A_3, AmmoType A_4, enp A_5, Action<cwt, amc> A_6)
		{
			this.c = A_0;
			this.d = new EntityAspectReference<amc, amc>(A_1);
			this.e = new EntityAspectReference<amc, amc>(A_2);
			this.b = A_4;
			this.a = A_3.af;
			this.h = A_5;
			this.i = A_6;
		}

		// Token: 0x060072D5 RID: 29397 RVA: 0x00304CC0 File Offset: 0x00302EC0
		public bool hj(b0b A_0, Vector3 A_1, Vector3 A_2, float A_3)
		{
			if (this.d.ao() != null && this.d.ao().a8() != null && A_0 != null && A_0.Area != null)
			{
				Point point = A_0.aj().a();
				if (!this.f.Contains(point))
				{
					ak1 ak = A_0.Area.a(point);
					if (ak != null)
					{
						foreach (b0b b0b in Enumerable.ToList<b0b>(ak.c.Values))
						{
							c5x c5x = (c5x)b0b;
							if (c5x.h.b != null && !this.g.Contains(c5x.qe()))
							{
								if (c5x.h.b != this.d.ao() && c5x.h.b != this.e.ao())
								{
									cwt cwt = this.a(c5x.h.b);
									cwt.af = this.a;
									cwt.x = this.b;
									dtb dtb = new dtb();
									dtb.b(false);
									dtb.c(false);
									awq.a(dtb, this.d.ao(), c5x.h.b, this.c.TypedDefinition, cwt, new b7x(this.h), null, false);
									if (this.d.ao().aa() is e3q)
									{
										awq.a(dtb, this.d.ao().a8(), c5x, true, true);
									}
									c5x.Zone.ActionManager.g9(dtb, atp.a);
									dz6.a(dtb);
								}
								this.g.Add(c5x.qe());
							}
						}
					}
					this.f.Add(point);
				}
			}
			return false;
		}

		// Token: 0x060072D6 RID: 29398 RVA: 0x00304EDC File Offset: 0x003030DC
		private cwt a(amc A_0)
		{
			double a_ = aw1.b(this.d.ao().a8(), A_0.a8());
			cmn a_2 = awq.a(this.d.ao(), A_0, null, null);
			cwt cwt = euf.a(this.d.ao().aa(), A_0.aa(), a_, a_2, 0.0, A_0.a8().l(), this.d.ao().aa().Darkvision, this.b, awq.f(this.d.ao()), 1.0, false, null, null, true, null);
			for (int i = 0; i < cwt.g.Count; i++)
			{
				edm edm = cwt.g[i];
				if (edm.Name == "leaveToxicGas" || edm.Name == "dazeSelfOnAttack")
				{
					cwt.g.RemoveAt(i);
					i--;
				}
			}
			return cwt;
		}

		// Token: 0x04002EE8 RID: 12008
		private Guid a;

		// Token: 0x04002EE9 RID: 12009
		private AmmoType b;

		// Token: 0x04002EEA RID: 12010
		private cd1 c;

		// Token: 0x04002EEB RID: 12011
		private EntityAspectReference<amc, amc> d;

		// Token: 0x04002EEC RID: 12012
		private EntityAspectReference<amc, amc> e;

		// Token: 0x04002EED RID: 12013
		private HashSet<Point> f = new HashSet<Point>();

		// Token: 0x04002EEE RID: 12014
		private HashSet<Guid> g = new HashSet<Guid>();

		// Token: 0x04002EEF RID: 12015
		private enp h;

		// Token: 0x04002EF0 RID: 12016
		private Action<cwt, amc> i;
	}
}
