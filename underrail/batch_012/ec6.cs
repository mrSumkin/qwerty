using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x020013FA RID: 5114
public sealed class ec6 : ay7
{
	// Token: 0x06007301 RID: 29441 RVA: 0x00307208 File Offset: 0x00305408
	public void pe(amc A_0, amc A_1, cd1 A_2, cwt A_3, AmmoType A_4, enp A_5 = null, Action<cwt, amc> A_6 = null)
	{
		this.a(A_0, A_1, A_2, A_4, 1.0, false, 0.0, false, null);
	}

	// Token: 0x06007302 RID: 29442 RVA: 0x00307238 File Offset: 0x00305438
	public void ae(amc A_0, amc A_1, cd1 A_2, AmmoType A_3)
	{
	}

	// Token: 0x06007303 RID: 29443 RVA: 0x0030723C File Offset: 0x0030543C
	public void a(amc A_0, amc A_1, cd1 A_2, AmmoType A_3, double A_4, bool A_5, double A_6, bool A_7 = false, enp A_8 = null)
	{
		if (A_0 != null && A_0.a8() != null && A_0.a8().Zone != null && eub.c(A_3))
		{
			ec6.a a_ = new ec6.a(A_0, A_1, A_2, A_3, A_4, A_5, A_6, A_7, A_8);
			A_0.a8().Zone.ActionManager.g9(a_, atp.a);
			dz6.a(a_);
		}
	}

	// Token: 0x020013FB RID: 5115
	[eiz("SSAA")]
	[Serializable]
	private class a : dvv
	{
		// Token: 0x06007305 RID: 29445 RVA: 0x003072B8 File Offset: 0x003054B8
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (A_0.GetValue("SSAA:A", typeof(amc)) as amc);
			this.b = (A_0.GetValue("SSAA:T", typeof(amc)) as amc);
			this.c = (A_0.GetValue("SSAA:W", typeof(cd1)) as cd1);
			this.d = (AmmoType)A_0.GetValue("SSAA:B", typeof(AmmoType));
			this.e = A_0.GetDouble("SSAA:H");
			this.j = (A_0.GetValue("SSAA:I", typeof(anp)) as anp);
			this.k = A_0.GetBoolean("SSAA:F");
			this.f = A_0.GetBoolean("SSAA:S");
			this.g = A_0.GetDouble("SSAA:D");
			this.h = A_0.GetBoolean("SSAA:U");
			this.i = (A_0.GetValue("SSAA:C", typeof(enp)) as enp);
		}

		// Token: 0x06007306 RID: 29446 RVA: 0x003073E0 File Offset: 0x003055E0
		public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			base.GetObjectData(info, ctx);
			info.AddValue("SSAA:A", this.a);
			info.AddValue("SSAA:T", this.b);
			info.AddValue("SSAA:W", this.c);
			info.AddValue("SSAA:B", this.d);
			info.AddValue("SSAA:H", this.e);
			info.AddValue("SSAA:I", this.j);
			info.AddValue("SSAA:F", this.k);
			info.AddValue("SSAA:S", this.f);
			info.AddValue("SSAA:D", this.g);
			info.AddValue("SSAA:U", this.h);
			info.AddValue("SSAA:C", this.i);
		}

		// Token: 0x06007307 RID: 29447 RVA: 0x003074B8 File Offset: 0x003056B8
		public a(amc A_0, amc A_1, cd1 A_2, AmmoType A_3, double A_4, bool A_5, double A_6, bool A_7, enp A_8)
		{
			this.a = A_0;
			this.b = A_1;
			this.c = A_2;
			this.d = A_3;
			this.e = A_4;
			this.f = A_5;
			this.g = A_6;
			this.h = A_7;
			this.i = A_8;
		}

		// Token: 0x06007308 RID: 29448 RVA: 0x00307510 File Offset: 0x00305710
		protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
		{
			if (this.j == null)
			{
				if (this.a == null || this.a.a8() == null || this.a.a8().Zone == null || this.b == null || this.b.a8() == null || this.b.a8().Zone == null)
				{
					return dc4.e;
				}
				if (this.h)
				{
					avt.a(this.a, this.b);
				}
				this.j = new anp(this.a.a8().aj().a(), this.a.a8().Area, this.c.TypedDefinition.ad() + 1f, 4L, false, 0L);
				this.j.a(new EventHandler<EventArgs>(this.a));
				this.j.k();
			}
			if (this.k)
			{
				HashSet<amc> hashSet = ec6.a.a(this.a, this.b, this.c.TypedDefinition.ad());
				int valueOrDefault = this.c.TypedDefinition.x().GetValueOrDefault(42);
				List<amc> list = new List<amc>();
				if (hashSet.Count > 0)
				{
					Vector2 a_ = this.a.a8().aj().b();
					foreach (amc amc in hashSet)
					{
						if (this.j.f().Contains(amc.a8().aj().a()))
						{
							double num = aw1.b(this.a.a8(), amc.a8());
							double num2 = bnx.a(a_, this.b.a8().aj().b(), amc.a8().aj().b());
							if (num <= (double)(this.c.TypedDefinition.ad() + 1f) && num2 <= (double)(valueOrDefault / 2))
							{
								list.Add(amc);
								if (this.h)
								{
									avt.a(this.a, amc);
								}
							}
						}
					}
				}
				int num3 = eub.c[this.d];
				bool flag = true;
				List<ec6.a.b> list2 = new List<ec6.a.b>();
				for (int i = 0; i < num3; i++)
				{
					amc amc2 = null;
					cwt cwt = null;
					bool a_2 = false;
					if (!this.b.aa().Dead)
					{
						cwt cwt2 = this.a(this.b, false, num3);
						amc2 = this.b;
						cwt = cwt2;
					}
					if ((amc2 == null || !cwt.b) && list.Count > 0)
					{
						List<amc> list3 = new List<amc>(list);
						int num4 = 0;
						while (num4 < 2 && list3.Count != 0)
						{
							int index = cuo.a.Next(list3.Count);
							amc amc3 = list3[index];
							list3.RemoveAt(index);
							cwt cwt3 = this.a(amc3, true, num3);
							if (cwt3.b)
							{
								amc2 = amc3;
								cwt = cwt3;
								a_2 = true;
								break;
							}
							num4++;
						}
					}
					if (amc2 != null)
					{
						list2.Add(new ec6.a.b(cwt, amc2, a_2)
						{
							e = (this.d == AmmoType.ShotgunShell_3)
						});
					}
				}
				Dictionary<c5x, ec6.a.b> dictionary = new Dictionary<c5x, ec6.a.b>();
				foreach (ec6.a.b b in list2)
				{
					if (b.a.b)
					{
						ec6.a.b b2;
						dictionary.TryGetValue(b.b.a8(), out b2);
						if (b2 == null)
						{
							b2 = new ec6.a.b(b.a.a(), b.b, b.c);
							dictionary[b.b.a8()] = b2;
						}
						else
						{
							b2.a.f.AddRange(b.a.f);
							if (b.a.e)
							{
								b2.d++;
							}
						}
						if (cuo.a.NextDouble() < 0.2)
						{
							b2.f++;
						}
						b2.e |= b.e;
					}
				}
				if (dictionary.Count == 0 && list2.Count > 0)
				{
					dictionary.Add(list2[0].b.a8(), list2[0]);
				}
				int num5 = 0;
				foreach (KeyValuePair<c5x, ec6.a.b> keyValuePair in dictionary)
				{
					if (keyValuePair.Value.a.b)
					{
						int num6 = Enumerable.Count<csk>(Enumerable.Where<csk>(keyValuePair.Value.a.f, new Func<csk, bool>(ec6.a.a.a.a)));
						if ((double)keyValuePair.Value.d >= (double)num6 / 2.0)
						{
							keyValuePair.Value.a.e = true;
						}
						else
						{
							keyValuePair.Value.a.e = false;
						}
						if (!keyValuePair.Value.b.aa().Passive)
						{
							num5++;
						}
						keyValuePair.Value.a.ad["MaxMirrorImageHits"] = keyValuePair.Value.f;
						keyValuePair.Value.a.aj = string.Format("{0} из {1} дробин наносят критический урон.", keyValuePair.Value.d, num6);
					}
					enp enp = null;
					if (keyValuePair.Value.e)
					{
						enp = new ec6.a.c();
					}
					if (this.i != null && keyValuePair.Key.h.b == this.b)
					{
						if (enp != null)
						{
							enp = new e29(this.i, enp);
						}
						else
						{
							enp = this.i;
						}
					}
					amc a_3 = this.a;
					amc a_4 = keyValuePair.Key.h.b;
					cwt a_5 = keyValuePair.Value.a;
					cd1 a_6 = this.c;
					bool a_7 = keyValuePair.Value.c;
					bool a_8 = keyValuePair.Key != this.b.a8() && !this.a.a8().IsPlayer;
					bool a_9 = flag;
					bool a_10 = flag;
					awq.a(a_3, a_4, a_5, a_6, enp, a_9, null, null, null, a_7, a_8, a_10, null, null);
					flag = false;
				}
				if (this.a.aa().Feats.Contains<eb9>())
				{
					eq7 eq = Enumerable.FirstOrDefault<eq7>(this.a.aa().StatusEffects.Get<eq7>());
					if (eq != null && eq.Stacks == eq.MaxStacks)
					{
						this.a.aa().StatusEffects.d(eq);
					}
					else
					{
						eq7 a_11 = new eq7();
						this.a.aa().StatusEffects.a(a_11, false, false, false);
					}
				}
				if (num5 > 0 && this.a.aa().Feats.Contains<etq>())
				{
					cyo cyo = Enumerable.FirstOrDefault<cyo>(this.a.aa().StatusEffects.Get<cyo>());
					if (cyo != null)
					{
						this.a.aa().StatusEffects.d(cyo);
					}
					cyo = new cyo();
					cyo.Stacks = num5;
					this.a.aa().StatusEffects.a(cyo, false, false, false);
				}
				return dc4.c;
			}
			return dc4.b;
		}

		// Token: 0x06007309 RID: 29449 RVA: 0x00307DAC File Offset: 0x00305FAC
		private cwt a(amc A_0, bool A_1, int A_2)
		{
			double num;
			if (A_1)
			{
				if (this.a.aa() is e3q)
				{
					if (this.a.a(A_0) != global::h.a)
					{
						num = 0.75;
					}
					else
					{
						num = 1.5;
					}
				}
				else if (this.a.a(A_0) != global::h.a)
				{
					num = 1.0;
				}
				else
				{
					num = 1.5;
				}
			}
			else if (this.a.aa() is e3q)
			{
				num = 1.0;
			}
			else
			{
				num = 1.25;
			}
			double a_ = aw1.b(this.a.a8(), A_0.a8());
			cmn cmn = awq.a(this.a, A_0, null, null);
			if (this.f)
			{
				cmn.b += this.a.aa().Offense.an();
			}
			cmn.b += this.g;
			if (this.a.aa().Feats.Contains<e24>())
			{
				cmn.d += (e24.a + (double)this.a.aa().GetSpecializationValue<ag9>(true) * ag9.a) / (double)A_2;
			}
			cyo cyo = Enumerable.FirstOrDefault<cyo>(this.a.aa().StatusEffects.Get<cyo>());
			if (cyo != null)
			{
				cmn.c += (double)cyo.Stacks * (etq.a + (double)this.a.aa().GetSpecializationValue<b62>(true) * b62.a);
			}
			if (this.a.aa().Feats.Contains<eb9>())
			{
				eq7 eq = Enumerable.FirstOrDefault<eq7>(this.a.aa().StatusEffects.Get<eq7>());
				if (eq != null)
				{
					cmn.b += eb9.a(this.a.aa(), eq.Stacks);
				}
			}
			cwt cwt = euf.a(this.a.aa(), A_0.aa(), a_, cmn, 0.0, A_0.a8().l(), this.a.aa().Darkvision, this.d, awq.f(this.a), num * this.e, false, null, null, true, null);
			double num2 = eub.b[this.d];
			for (int i = 0; i < cwt.f.Count; i++)
			{
				int num3 = 0;
				if (this.a.aa().Feats.Contains<c59>())
				{
					num3 = cuo.a.Next(c59.a.LowerBoundary, (int)((double)c59.a.UpperBoundary + (double)this.a.aa().GetSpecializationValue<cuh>(true) * cuh.a + 1.0));
				}
				if (cwt.f[i].DamageType == DamageType.Mechanical)
				{
					cwt.f[i] = new csk(DamageType.Mechanical, (int)Math.Max(1.0, (double)cwt.f[i].Amount * num2) + num3);
				}
			}
			return cwt;
		}

		// Token: 0x0600730A RID: 29450 RVA: 0x00308138 File Offset: 0x00306338
		private static HashSet<amc> a(amc A_0, amc A_1, float A_2)
		{
			HashSet<amc> hashSet = new HashSet<amc>();
			if (!A_1.a8().TileFormationModifiers.c(4L))
			{
				foreach (b0b b0b in A_1.a8().Area.Entities)
				{
					c5x c5x = (c5x)b0b;
					if (c5x.h.b != null && c5x.h.b.a8().j == cgy.b && !c5x.h.b.aa().Dead && c5x.h.b != A_1 && c5x.h.b != A_0 && aw1.b(A_0.a8(), c5x) <= (double)(A_2 + 1f))
					{
						hashSet.Add(c5x.h.b);
					}
				}
			}
			return hashSet;
		}

		// Token: 0x0600730B RID: 29451 RVA: 0x0030824C File Offset: 0x0030644C
		[dcc("SSAA:mIF")]
		private void a(object A_0, EventArgs A_1)
		{
			this.k = true;
		}

		// Token: 0x04002EF7 RID: 12023
		private new amc a;

		// Token: 0x04002EF8 RID: 12024
		private amc b;

		// Token: 0x04002EF9 RID: 12025
		private cd1 c;

		// Token: 0x04002EFA RID: 12026
		private AmmoType d;

		// Token: 0x04002EFB RID: 12027
		private double e;

		// Token: 0x04002EFC RID: 12028
		private bool f;

		// Token: 0x04002EFD RID: 12029
		private double g;

		// Token: 0x04002EFE RID: 12030
		private bool h;

		// Token: 0x04002EFF RID: 12031
		private enp i;

		// Token: 0x04002F00 RID: 12032
		private new anp j;

		// Token: 0x04002F01 RID: 12033
		private new bool k;

		// Token: 0x020013FC RID: 5116
		private sealed class b
		{
			// Token: 0x0600730C RID: 29452 RVA: 0x00308258 File Offset: 0x00306458
			public b(cwt A_0, amc A_1, bool A_2)
			{
				this.a = A_0;
				this.b = A_1;
				this.c = A_2;
				if (A_0 != null && A_0.e)
				{
					this.d++;
				}
			}

			// Token: 0x04002F02 RID: 12034
			public cwt a;

			// Token: 0x04002F03 RID: 12035
			public amc b;

			// Token: 0x04002F04 RID: 12036
			public bool c;

			// Token: 0x04002F05 RID: 12037
			public int d;

			// Token: 0x04002F06 RID: 12038
			public bool e;

			// Token: 0x04002F07 RID: 12039
			public int f;
		}

		// Token: 0x020013FD RID: 5117
		[eiz("SS3C")]
		[Serializable]
		private sealed class c : enp, ISerializable
		{
			// Token: 0x0600730D RID: 29453 RVA: 0x00308294 File Offset: 0x00306494
			private c(SerializationInfo A_0, StreamingContext A_1)
			{
			}

			// Token: 0x0600730E RID: 29454 RVA: 0x0030829C File Offset: 0x0030649C
			public void GetObjectData(SerializationInfo info, StreamingContext context)
			{
			}

			// Token: 0x0600730F RID: 29455 RVA: 0x003082A0 File Offset: 0x003064A0
			public c()
			{
			}

			// Token: 0x06007310 RID: 29456 RVA: 0x003082AC File Offset: 0x003064AC
			public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
			{
				if (A_1 != null && !A_1.aa().Dead && A_2.b && A_3.a != null && !A_1.aa().Passive && !A_1.aa().b(d8o.e))
				{
					if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(ec6.a.c.a.a.b)), new Func<csk, int>(ec6.a.c.a.a.a)) > 0 && cuo.a.NextDouble() < 0.5)
					{
						if (A_1.aa().StatusEffects.a(eok.c) && !A_1.aa().StatusEffects.a(a2a.a))
						{
							if (A_1.aa().Passive || A_1.aa().c(d8o.e) || A_1.aa().d(CharacterImmunities.Stun))
							{
								etm a_ = new etm(new ap9(A_1.aa()), "оглушению");
								bey.a(a_, A_1.aa(), A_1);
								a7v.a(a_);
								bmj.a(A_1.a8(), new ba0());
								return;
							}
							els els = awq.a(A_1.aa(), d0u.b);
							A_1.aa().StatusEffects.a(els, false, false, false);
							if (A_0.aa() is e3q && els is ab3)
							{
								cxc.a(eyy.by);
								return;
							}
						}
						else
						{
							if (A_1.aa().d(CharacterImmunities.Daze))
							{
								if (A_0 != null)
								{
									etm a_2 = new etm(new ap9(A_1.aa()), "дезориентации");
									bey.a(a_2, A_0.aa(), A_1.aa(), A_1);
									a7v.a(a_2);
								}
								bmj.a(A_1.a8(), new ba0());
								return;
							}
							if (euf.l(A_1.aa()))
							{
								c6f a_3 = new c6f(new ap9(A_1.aa()), (A_0 != null) ? new ap9(A_0.aa()) : null, "дезориентации");
								bey.a(a_3, A_2, A_1);
								a7v.a(a_3);
								bmj.a(A_1.a8(), new dym());
								return;
							}
							A_1.aa().StatusEffects.a(new eok(d0u.b), false, false, false);
							vr a_4 = new vr(new ap9(A_1.aa()), (A_0 != null) ? new ap9(A_0.aa()) : null, "{0}: дезориентация.", new Color?(adi.j), null);
							A_1.a8().c().a(Guid.NewGuid().ToString(), "Stun", 1f, c9z.a, false, false);
							bey.a(a_4, A_2, A_1);
							a7v.a(a_4);
						}
					}
				}
			}

			// Token: 0x020013FE RID: 5118
			[CompilerGenerated]
			[Serializable]
			private sealed class a
			{
				// Token: 0x06007313 RID: 29459 RVA: 0x003085C4 File Offset: 0x003067C4
				internal bool b(csk A_0)
				{
					return A_0.DamageType == DamageType.Mechanical;
				}

				// Token: 0x06007314 RID: 29460 RVA: 0x003085D0 File Offset: 0x003067D0
				internal int a(csk A_0)
				{
					return A_0.Amount;
				}

				// Token: 0x04002F08 RID: 12040
				public static readonly ec6.a.c.a a = new ec6.a.c.a();

				// Token: 0x04002F09 RID: 12041
				public static Func<csk, bool> b;

				// Token: 0x04002F0A RID: 12042
				public static Func<csk, int> c;
			}
		}

		// Token: 0x020013FF RID: 5119
		[CompilerGenerated]
		[Serializable]
		private new sealed class a
		{
			// Token: 0x06007317 RID: 29463 RVA: 0x003085F0 File Offset: 0x003067F0
			internal bool a(csk A_0)
			{
				return A_0.DamageType == DamageType.Mechanical;
			}

			// Token: 0x04002F0B RID: 12043
			public static readonly ec6.a.a a = new ec6.a.a();

			// Token: 0x04002F0C RID: 12044
			public static Func<csk, bool> b;
		}
	}
}
