using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Items;

// Token: 0x0200135C RID: 4956
[eiz("SGPMH")]
[Serializable]
public class cgw : aig, ISerializable
{
	// Token: 0x06007072 RID: 28786 RVA: 0x002F3A04 File Offset: 0x002F1C04
	private cgw(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (A_0.GetValue("SGPMH:A", typeof(EntityAspectReference<amc, amc>)) as EntityAspectReference<amc, amc>);
		this.b = (A_0.GetValue("SGPMH:P", typeof(EntityAspectReference<amc, amc>)) as EntityAspectReference<amc, amc>);
		this.c = (A_0.GetValue("SGPMH:T", typeof(HashSet<Point>)) as HashSet<Point>);
		this.d = (A_0.GetValue("SGPMH:E", typeof(HashSet<Guid>)) as HashSet<Guid>);
		this.e = (A_0.GetValue("SGPMH:W", typeof(cd1)) as cd1);
		this.f = A_0.GetBoolean("SGPMH:D");
		this.g = A_0.GetDouble("SGPMH:R");
		this.h = A_0.GetString("SGPMH:H");
		this.i = (A_0.GetValue("SGPMH:S", typeof(string[])) as string[]);
		this.j = A_0.GetInt32("SGPMH:X");
	}

	// Token: 0x06007073 RID: 28787 RVA: 0x002F3B34 File Offset: 0x002F1D34
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("SGPMH:A", this.a);
		info.AddValue("SGPMH:P", this.b);
		info.AddValue("SGPMH:T", this.c);
		info.AddValue("SGPMH:E", this.d);
		info.AddValue("SGPMH:W", this.e);
		info.AddValue("SGPMH:D", this.f);
		info.AddValue("SGPMH:R", this.g);
		info.AddValue("SGPMH:H", this.h);
		info.AddValue("SGPMH:S", this.i);
		info.AddValue("SGPMH:X", this.j);
	}

	// Token: 0x06007074 RID: 28788 RVA: 0x002F3BEC File Offset: 0x002F1DEC
	public cgw(amc A_0, amc A_1, cd1 A_2, bool A_3 = false, double A_4 = 0.25, string A_5 = "xpbl_SoundGunWaveHitSmall", string[] A_6 = null)
	{
		this.a = new EntityAspectReference<amc, amc>(A_0);
		this.b = new EntityAspectReference<amc, amc>(A_1);
		this.e = A_2;
		this.f = A_3;
		this.g = A_4;
		this.h = A_5;
		this.i = A_6;
	}

	// Token: 0x06007075 RID: 28789 RVA: 0x002F3C54 File Offset: 0x002F1E54
	public bool hj(b0b A_0, Vector3 A_1, Vector3 A_2, float A_3)
	{
		if (this.i == null || this.i.Length <= this.j)
		{
			return false;
		}
		if (this.a.ao() != null && A_0 != null && A_0.Area != null)
		{
			Point point = A_0.aj().a();
			if (!this.c.Contains(point))
			{
				ak1 ak = A_0.Area.a(point);
				if (ak != null)
				{
					c5x c5x = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(ak.c.Values, new Func<b0b, bool>(cgw.a.a.a))) as c5x;
					foreach (b0b b0b in Enumerable.ToList<b0b>(ak.c.Values))
					{
						c5x c5x2 = (c5x)b0b;
						if (c5x2.h.b != null && !this.d.Contains(c5x2.qe()))
						{
							if (c5x2.h.b != this.a.ao() && c5x2.h.b != this.b.ao())
							{
								cwt cwt = this.a(c5x2.h.b);
								enp a_;
								if (this.f)
								{
									a_ = new cgw.b();
								}
								else
								{
									a_ = null;
								}
								awq.a(this.a.ao(), c5x2.h.b, cwt, this.e, a_, false, null, "None", null, false, false, false, null, null);
								if (cwt.b)
								{
									if (!string.IsNullOrEmpty(this.h))
									{
										boj.a(c5x2, this.h, 1, double.MaxValue, true, true, null, null, null, null, false);
									}
									if (c5x != null)
									{
										string a_2 = this.i[this.j];
										c5x2.c().a(Guid.NewGuid().ToString(), a_2, 0.75f, c9z.a, false, false);
									}
									int num = this.j + 1;
									this.j = num;
									if (num >= this.i.Length)
									{
										return false;
									}
								}
							}
							this.d.Add(c5x2.qe());
						}
					}
				}
				this.c.Add(point);
			}
		}
		return false;
	}

	// Token: 0x06007076 RID: 28790 RVA: 0x002F3F30 File Offset: 0x002F2130
	private cwt a(amc A_0)
	{
		double a_ = aw1.b(this.a.ao().a8(), A_0.a8());
		cmn a_2 = awq.a(this.a.ao(), A_0, this.e, null);
		cwt cwt = euf.a(this.a.ao().aa(), A_0.aa(), a_, a_2, -100000.0, A_0.a8().l(), this.a.ao().aa().Darkvision, AmmoType.SonicWave, awq.f(this.a.ao()), 1.0, false, this.e, null, true, null);
		for (int i = 0; i < cwt.f.Count; i++)
		{
			csk csk = cwt.f[i];
			cwt.f[i] = new csk(csk.DamageType, (int)Math.Max(1.0, (double)csk.Amount * this.g));
		}
		return cwt;
	}

	// Token: 0x04002DFB RID: 11771
	private EntityAspectReference<amc, amc> a;

	// Token: 0x04002DFC RID: 11772
	private EntityAspectReference<amc, amc> b;

	// Token: 0x04002DFD RID: 11773
	private HashSet<Point> c = new HashSet<Point>();

	// Token: 0x04002DFE RID: 11774
	private HashSet<Guid> d = new HashSet<Guid>();

	// Token: 0x04002DFF RID: 11775
	private cd1 e;

	// Token: 0x04002E00 RID: 11776
	private bool f;

	// Token: 0x04002E01 RID: 11777
	private double g;

	// Token: 0x04002E02 RID: 11778
	private string h;

	// Token: 0x04002E03 RID: 11779
	private string[] i;

	// Token: 0x04002E04 RID: 11780
	private int j;

	// Token: 0x0200135D RID: 4957
	[eiz("SGPMHa")]
	[Serializable]
	public sealed class b : enp, ISerializable
	{
		// Token: 0x06007077 RID: 28791 RVA: 0x002F4064 File Offset: 0x002F2264
		private b(SerializationInfo A_0, StreamingContext A_1)
		{
		}

		// Token: 0x06007078 RID: 28792 RVA: 0x002F406C File Offset: 0x002F226C
		public void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
		}

		// Token: 0x06007079 RID: 28793 RVA: 0x002F4070 File Offset: 0x002F2270
		public b()
		{
		}

		// Token: 0x0600707A RID: 28794 RVA: 0x002F407C File Offset: 0x002F227C
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (A_1 != null && A_3 != null && !A_3.c && A_3.a != null)
			{
				if (Enumerable.Sum<csk>(A_3.a, new Func<csk, int>(cgw.b.a.a.a)) > 0)
				{
					if (A_1.aa().Passive || A_1.aa().c(d8o.e) || A_1.aa().d(CharacterImmunities.Daze))
					{
						etm a_ = new etm(new ap9(A_1.aa()), "дезориентации");
						bey.a(a_, A_1.aa(), A_1);
						a7v.a(a_);
						bmj.a(A_1.a8(), new ba0());
						return;
					}
					eok a_2 = new eok(d0u.b * bc9.a);
					A_1.aa().StatusEffects.a(a_2, false, false, false);
				}
			}
		}

		// Token: 0x0200135E RID: 4958
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x0600707D RID: 28797 RVA: 0x002F418C File Offset: 0x002F238C
			internal int a(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x04002E05 RID: 11781
			public static readonly cgw.b.a a = new cgw.b.a();

			// Token: 0x04002E06 RID: 11782
			public static Func<csk, int> b;
		}
	}

	// Token: 0x0200135F RID: 4959
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06007080 RID: 28800 RVA: 0x002F41AC File Offset: 0x002F23AC
		internal bool a(b0b A_0)
		{
			return A_0.Layer == 0 && A_0.IsFloor;
		}

		// Token: 0x04002E07 RID: 11783
		public static readonly cgw.a a = new cgw.a();

		// Token: 0x04002E08 RID: 11784
		public static Func<b0b, bool> b;
	}
}
