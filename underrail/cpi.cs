using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.AI.Behaviors.Custom.Xphw;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules;

// Token: 0x020009E7 RID: 2535
[eiz("XPHWEXOBF")]
[Serializable]
public sealed class cpi : bdw, ISerializable
{
	// Token: 0x06003C9B RID: 15515 RVA: 0x001673B4 File Offset: 0x001655B4
	private cpi(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003C9C RID: 15516 RVA: 0x001673BC File Offset: 0x001655BC
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003C9D RID: 15517 RVA: 0x001673C0 File Offset: 0x001655C0
	public cpi()
	{
	}

	// Token: 0x06003C9E RID: 15518 RVA: 0x001673CC File Offset: 0x001655CC
	public void av(c1a A_0, cyt A_1)
	{
		dqp.g();
		if (dh7.a == null || dh7.a.c == A_0.y8())
		{
			if (!dqp.e())
			{
				dqp.a();
			}
			dqp.a(A_0);
			dqp.a(true);
			if (bpo.GetServiceOrThrow<cnk>().aqu().r().GetPrimitivePropertyValue<bool>("faction_xphw_exoBase_returnedToCryo", new bool?(false)).Value)
			{
				this.c(A_0);
				return;
			}
			bool? flag = dqp.a(A_0, false);
			if (flag != null)
			{
				this.b(A_0);
			}
			if (flag != null || !dqp.a(A_0, false, false))
			{
				bool? flag2 = flag;
				bool flag3 = false;
				if (!(flag2.GetValueOrDefault() == flag3 & flag2 != null))
				{
					goto IL_1EB;
				}
			}
			List<string> list = dqp.a(false, A_0, null);
			if (Enumerable.Any<string>(list))
			{
				List<csd> list2 = dqp.a(list[cuo.a.Next(list.Count)], A_0);
				if (Enumerable.Any<csd>(list2))
				{
					bool a_ = false;
					bu6 service = bpo.GetService<bu6>();
					if (service != null)
					{
						int num = 7;
						int num2 = (list2.Count - 2 < num) ? ((list2.Count - 1 >= num) ? 1 : 0) : 2;
						if (service.aq2() >= GameDifficulty.Dominating)
						{
							num2 = 0;
							a_ = (cuo.a.Next(0, 101) <= 20);
						}
						else if (service.aq2() >= GameDifficulty.Hard)
						{
							num2 = ((list2.Count - 1 >= num) ? 1 : 0);
						}
						if (num2 != 0)
						{
							list2.RemoveRange(list2.Count - num2, num2);
						}
					}
					dqp.a(list2, false, dqp.d(), true, 0.5f, 0.5f, a_, null);
					this.b(A_0);
				}
			}
		}
		else if (dqp.d(A_0))
		{
			this.c(A_0);
		}
		IL_1EB:
		this.d(A_0, A_1);
		if (A_1.r().GetPrimitivePropertyValue<int>("loc_xphw_exoBase_cognatorKeycardLocation", new int?(0)).Value == 0)
		{
			A_1.r()["loc_xphw_exoBase_cognatorKeycardLocation"] = cuo.a.Next(1, 3);
		}
		if (A_0.y8().Equals("xphw_exobase_lab2"))
		{
			this.e(A_0, A_1);
			return;
		}
		if (A_0.y8().Equals("xphw_exobase_com"))
		{
			this.a(A_0, A_1);
			return;
		}
		if (A_0.y8().Equals("xphw_exobase_out"))
		{
			this.a(A_0);
			return;
		}
		if (A_0.y8().Equals("xphw_exobase_ent"))
		{
			this.b(A_0, A_1);
			return;
		}
		if (A_0.y8().StartsWith("xphw_exobase_med"))
		{
			this.c(A_0, A_1);
		}
	}

	// Token: 0x06003C9F RID: 15519 RVA: 0x001676A8 File Offset: 0x001658A8
	private void c(c1a A_0)
	{
		d60 addon = A_0.GetAddon<d60>();
		d02 service = bpo.GetService<d02>();
		if (addon != null && service != null)
		{
			HashSet<string> hashSet = new HashSet<string>();
			foreach (d4n d4n in service.ahl())
			{
				string text = dqp.c(d4n.b.a8());
				if (!string.IsNullOrEmpty(text))
				{
					hashSet.Add(text);
				}
			}
			if (Enumerable.Any<string>(hashSet))
			{
				foreach (string text2 in hashSet)
				{
					List<b0b> list = addon.ab4(new string[]
					{
						"SquadName_" + text2
					});
					foreach (b0b b0b in list)
					{
						c5x c5x = (c5x)b0b;
						c5x.b("Area_" + c5x.Area.y8());
						dqp.a(c5x);
					}
					dqp.a(list, text2, A_0.y8());
				}
			}
		}
	}

	// Token: 0x06003CA0 RID: 15520 RVA: 0x00167820 File Offset: 0x00165A20
	private void b(c1a A_0)
	{
		d60 addon = A_0.GetAddon<d60>();
		if (addon != null)
		{
			b0b b0b = addon.ab5("canImportDefenses");
			if (b0b == null)
			{
				return;
			}
			b0b.GetAspect<e3l>().a.Remove("canImportDefenses");
			doq a_ = doq.a(Path.Combine(d5x.q(), A_0.y8() + "_l2") + ".uzl");
			A_0.a(a_, 1, null);
			foreach (b0b b0b2 in addon.ab4(new string[]
			{
				"tippableShelves"
			}))
			{
				e4x e4x = b0b2.GetAspect<cd0>() as e4x;
				if (e4x != null)
				{
					int y = e4x.b.Y;
					e4x.a = "Objects\\Utilities\\xphw_duty_shelf_kipped";
					e4x.b.X = ((y == 0 || y == 1) ? 0 : 1);
					e4x.b.Y = ((y == 0 || y == 2) ? 0 : 1);
					b0b2.Size = new Vector3((e4x.b.Y == 0) ? 1.5f : 0.25f, (e4x.b.Y == 1) ? 1.5f : 0.25f, b0b2.Size.Z);
					b0b2.TileFormationModifiers.b(new byte[]
					{
						0,
						2
					});
					c7j c7j = b0b2.GetAspect<bim>() as c7j;
					if (c7j != null)
					{
						c7j.t().Clear();
						if (e4x.b.Y == 1)
						{
							c7j.t().Add(HorizontalDirection.East);
							c7j.t().Add(HorizontalDirection.West);
						}
						else
						{
							c7j.t().Add(HorizontalDirection.North);
							c7j.t().Add(HorizontalDirection.South);
						}
					}
				}
			}
		}
	}

	// Token: 0x06003CA1 RID: 15521 RVA: 0x00167A48 File Offset: 0x00165C48
	private void e(c1a A_0, cyt A_1)
	{
		if (A_1 != null && A_1.r().GetPrimitivePropertyValue<bool>("faction_xphw_exoBase_superSoldiers_deployed", new bool?(false)).Value)
		{
			d60 addon = A_0.GetAddon<d60>();
			if (addon != null)
			{
				foreach (b0b b0b in addon.ab4(new string[]
				{
					"cryochamber"
				}))
				{
					cd0 aspect = b0b.GetAspect<cd0>();
					if (aspect != null)
					{
						aspect.b.X = 1;
					}
				}
				foreach (b0b b0b2 in addon.ab4(new string[]
				{
					"cryogate"
				}))
				{
					cd0 aspect2 = b0b2.GetAspect<cd0>();
					if (aspect2 != null)
					{
						aspect2.b.X = 5;
					}
				}
			}
		}
	}

	// Token: 0x06003CA2 RID: 15522 RVA: 0x00167B60 File Offset: 0x00165D60
	private void d(c1a A_0, cyt A_1)
	{
		d60 addon = A_0.GetAddon<d60>();
		if (addon != null)
		{
			int num = A_1.l() + A_0.qe().GetHashCode();
			Random random = new Random(num);
			string text = "randomlyLockedDoor";
			List<b0b> list = addon.ab4(new string[]
			{
				text
			});
			if (list != null && Enumerable.Any<b0b>(list))
			{
				foreach (b0b b0b in list)
				{
					if (random.Next(0, 101) < 50)
					{
						this.a(b0b as c5x);
					}
					e3l aspect = b0b.GetAspect<e3l>();
					aspect.a.Remove(text);
					aspect.a();
				}
			}
			List<b0b> list2 = addon.ab4(new string[]
			{
				text + "_exclusive"
			});
			if (list2 != null && Enumerable.Any<b0b>(list2))
			{
				foreach (b0b b0b2 in list2)
				{
					e3l aspect2 = b0b2.GetAspect<e3l>();
					aspect2.a.Remove(text + "_exclusive");
					aspect2.a();
				}
				this.a(Enumerable.FirstOrDefault<b0b>(cuo.ShuffleList<b0b>(list2, new int?(num))) as c5x);
			}
		}
	}

	// Token: 0x06003CA3 RID: 15523 RVA: 0x00167CF0 File Offset: 0x00165EF0
	private void a(c5x A_0)
	{
		if (A_0 != null)
		{
			cnb cnb = A_0.GetAspect<bim>() as cnb;
			if (cnb != null && cnb.b() != null)
			{
				d2b aspect = A_0.GetAspect<d2b>();
				if (aspect != null)
				{
					aspect.e(true);
				}
				c5x c5x = new ar7(cnb.b().Value, A_0.Area).ao() as c5x;
				if (c5x != null)
				{
					d2b aspect2 = c5x.GetAspect<d2b>();
					if (aspect2 != null)
					{
						aspect2.e(true);
					}
				}
			}
		}
	}

	// Token: 0x06003CA4 RID: 15524 RVA: 0x00167D80 File Offset: 0x00165F80
	private void a(c1a A_0)
	{
		if (dh7.a != null && dh7.a.d != null && dh7.a.d.ToLower().StartsWith("rift"))
		{
			d7o.a(Xphw_GunslingerCommentCodeEnum.Event_Rifted, false, false);
		}
	}

	// Token: 0x06003CA5 RID: 15525 RVA: 0x00167DD4 File Offset: 0x00165FD4
	private void c(c1a A_0, cyt A_1)
	{
		int value = A_1.r().GetPrimitivePropertyValue<int>("loc_xphw_exoBase_cognatorKeycardLocation", new int?(0)).Value;
		if (value != 0 && value != 3 && A_0.y8().Equals("xphw_exobase_med" + value.ToString()))
		{
			d60 addon = A_0.GetAddon<d60>();
			if (addon != null)
			{
				c7j c7j = (Enumerable.FirstOrDefault<b0b>(cuo.ShuffleList<b0b>(addon.ab4(new string[]
				{
					"cognatorKeycardCandidate"
				}), null)) as c5x).GetAspect<bim>() as c7j;
				if (c7j != null)
				{
					coh coh = new d48(ez2.CreateDefinitonProvider<a0z>("plot\\xphw\\exoBase_cognatorMedchamber"));
					if (coh != null)
					{
						c7j.ItemContainer.z3(coh, true);
						A_1.r()["loc_xphw_exoBase_cognatorKeycardLocation"] = 3;
					}
				}
			}
		}
	}

	// Token: 0x06003CA6 RID: 15526 RVA: 0x00167EB4 File Offset: 0x001660B4
	private void b(c1a A_0, cyt A_1)
	{
		if (A_1 != null && A_1.r().GetPrimitivePropertyValue<bool>("faction_xphw_exoBase_restrictedAccess", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("faction_xphw_exoBase_exosoldiers_stopDeployment", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("faction_xphw_exoBase_superSoldiers_stopDeployment", new bool?(false)).Value)
		{
			c5x c5x = new ar7(new Guid("d60d62de-4b0e-44bf-bd01-7016ca4faca8"), A_0.n(A_0.y8())).ao() as c5x;
			if (c5x.s.b != null)
			{
				if (!c5x.s.b.ab())
				{
					return;
				}
				c5x.s.b.g(false);
			}
			d2b aspect = c5x.GetAspect<d2b>();
			if (aspect != null)
			{
				aspect.a(true, false);
			}
			bvy aspect2 = (new ar7(new Guid("86a08035-2ee6-4d46-8168-e8422529c86f"), A_0.n(A_0.y8())).ao() as c5x).GetAspect<bvy>();
			if (aspect2 != null)
			{
				aspect2.c(2);
				aspect2.d(0);
			}
		}
	}

	// Token: 0x06003CA7 RID: 15527 RVA: 0x00167FE4 File Offset: 0x001661E4
	private void a(c1a A_0, cyt A_1)
	{
		if (A_1 == null || !A_1.r().GetPrimitivePropertyValue<bool>("loc_xphw_exobase_voidIntro", new bool?(false)).Value)
		{
			return;
		}
		c5x c5x = new ar7(new Guid("04415430-2dc3-4f19-9325-5a7facb1eeed"), A_0.n("xphw_exobase_com")).ao() as c5x;
		if (c5x != null && c5x.h.b != null && c5x.t.b != null)
		{
			if (A_1.r().GetPrimitivePropertyValue<bool>("loc_xphw_exoBase_voidBattleWon", new bool?(false)).Value && c5x.h.b.am() != bln.l7)
			{
				a0l.a(c5x, "commander_cryochamber", true);
				c5x.h.b.a(bln.l7);
				c5x.t.b.y6()[ddq.bc] = "npc_xphw_psiCommander_afterBattle";
				c5x.t.b.y6()[ddq.ay] = new bt4("commander_cryochamber");
				c5x c5x2 = new ar7(c29.a, A_0.n("xphw_exobase_com")).ao() as c5x;
				if (c5x2 != null)
				{
					a0l.a(c5x2, "xphw_gunslinger_com1", true);
					return;
				}
			}
			else if (A_1.r().GetPrimitivePropertyValue<bool>("loc_xphw_exoBase_voidBattleLost", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("npc_xphw_psiCommander_incapacitated", new bool?(false)).Value)
			{
				A_1.r()["npc_xphw_psiCommander_incapacitated"] = true;
				c5x.t.b.y6()[ddq.w] = CharacterState.Stunned;
			}
		}
	}
}
