using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Lightning;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000A5E RID: 2654
[eiz("T12")]
[Serializable]
public sealed class blq : cze, ISerializable
{
	// Token: 0x06003EB2 RID: 16050 RVA: 0x0017AB00 File Offset: 0x00178D00
	private blq(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("T12:P");
	}

	// Token: 0x06003EB3 RID: 16051 RVA: 0x0017AB1C File Offset: 0x00178D1C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("T12:P", this.a);
	}

	// Token: 0x06003EB4 RID: 16052 RVA: 0x0017AB38 File Offset: 0x00178D38
	public bool a()
	{
		return this.a;
	}

	// Token: 0x06003EB5 RID: 16053 RVA: 0x0017AB40 File Offset: 0x00178D40
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06003EB6 RID: 16054 RVA: 0x0017AB4C File Offset: 0x00178D4C
	public blq()
	{
	}

	// Token: 0x06003EB7 RID: 16055 RVA: 0x0017AB58 File Offset: 0x00178D58
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.i.b != null && c5x.h.b != null)
		{
			bool flag = true;
			a3f a3f = c5x.GetAspect<a3f>();
			if (a3f != null)
			{
				flag = !a3f.a().GetPrimitivePropertyValue<bool>(bah.b, new bool?(false)).Value;
				a3f.a().RemoveProperty(bah.b);
			}
			else
			{
				a3f = new a3f(c5x);
				c5x.SetAspect<a3f>(a3f);
			}
			a3f.a()[bah.b] = true;
			awx awx = new awx("turretStateChange");
			awx awx2 = awx;
			awx2.a(awx2.kh() | (m7.b | m7.k));
			awx.a(false);
			if (!flag)
			{
				c5x.c().a("stateChange", "Xpbl_LemurianSeaHorseTurretMovement", 1f, c9z.a, false, false);
			}
			if (!this.a)
			{
				string text = c5x.h.b.am().ToLowerInvariant();
				HorizontalDirection a_;
				if (!(text == "xpbl_sht_s"))
				{
					if (!(text == "xpbl_sht_n"))
					{
						if (!(text == "xpbl_sht_e"))
						{
							if (!(text == "xpbl_sht_w"))
							{
							}
							a_ = HorizontalDirection.West;
						}
						else
						{
							a_ = HorizontalDirection.East;
						}
					}
					else
					{
						a_ = HorizontalDirection.North;
					}
				}
				else
				{
					a_ = HorizontalDirection.South;
				}
				awx.ad().Add(new bxp(c5x, a_));
			}
			else if (Enumerable.FirstOrDefault<bsf>(Enumerable.Where<bsf>(Enumerable.OfType<bsf>(c5x.RaysEmitters), new Func<bsf, bool>(blq.a.a.a))) == null)
			{
				ah7 ah = new ah7("LemurianSeaHorseTurretLight", null);
				ah.Layer = aju.x;
				if (flag)
				{
					ah.Light = new ae8(new Color(106, 243, 242), 0.25f, LightType.Increment);
				}
				else
				{
					ah.Light = new ae8(new Color(106, 243, 242), 0.05f, LightType.Increment);
				}
				ah.LightFadeRate = 0.08f;
				ah.Range = 4f;
				ah.g().be(c5x);
				if (!flag)
				{
					dtb dtb = new dtb();
					dtb.a(m7.k);
					List<auv> list = dtb.ad();
					exq exq = new exq(c5x, ah.Name);
					exq.b(0.05);
					exq.c(0.25);
					exq.a(0.00012);
					list.Add(exq);
					c5x.Zone.ActionManager.g9(dtb, atp.a);
				}
			}
			if (!flag)
			{
				e4t item = new e4t(c5x.h.b, this.a ? CharacterState.Custom2 : CharacterState.Custom3, dz6.b(cux.a), 0, null, 1);
				awx.ad().Add(item);
			}
			if (this.a)
			{
				if (c5x.t.b != null)
				{
					string classPropertyValue = c5x.t.b.y6().GetClassPropertyValue<string>(ddq.at);
					if (classPropertyValue != null)
					{
						c5x.h.b.aa().FactionId = classPropertyValue;
					}
				}
				awx.ad().Add(new a4s(new epw(null), null, new ar7(c5x), null));
				awx.ad().Add(new a4s(new b16(null), null, new ar7(c5x), null));
				c5x.h.b.aa().Passive = false;
			}
			else
			{
				awx.ad().Add(new a4s(new epw(new CharacterState?(CharacterState.Custom1)), null, new ar7(c5x), null));
				awx.ad().Add(new a4s(new b16(new int?(0)), null, new ar7(c5x), null));
				dtb dtb2 = new dtb();
				dtb2.a(m7.k);
				if (!flag)
				{
					List<auv> list2 = dtb2.ad();
					exq exq2 = new exq(c5x, "LemurianSeaHorseTurretLight");
					exq2.b(0.25);
					exq2.c(0.05);
					exq2.a(0.00012);
					list2.Add(exq2);
				}
				dtb2.ad().Add(new a4s(new dub("LemurianSeaHorseTurretLight"), null, new ar7(c5x), null));
				c5x.Zone.ActionManager.g9(dtb2, atp.a);
				if (c5x.t.b != null)
				{
					new bzv(c5x.t.b.y6()).e();
					string classPropertyValue2 = c5x.t.b.y6().GetClassPropertyValue<string>(ddq.au);
					if (classPropertyValue2 != null)
					{
						c5x.h.b.aa().FactionId = classPropertyValue2;
					}
				}
				c5x.h.b.aa().Passive = true;
			}
			c5x.i.b.b(awx, atp.a);
		}
	}

	// Token: 0x04001BC3 RID: 7107
	private new bool a;

	// Token: 0x02000A5F RID: 2655
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06003EBA RID: 16058 RVA: 0x0017B0B4 File Offset: 0x001792B4
		internal bool a(bsf A_0)
		{
			return A_0.Definition != null && A_0.Definition.Name == "LemurianSeaHorseTurretLight";
		}

		// Token: 0x04001BC4 RID: 7108
		public static readonly blq.a a = new blq.a();

		// Token: 0x04001BC5 RID: 7109
		public static Func<bsf, bool> b;
	}
}
