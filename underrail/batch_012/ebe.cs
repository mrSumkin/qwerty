using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Items;

// Token: 0x020010C5 RID: 4293
[eiz("SPS")]
[Serializable]
public sealed class ebe : cze
{
	// Token: 0x06005A51 RID: 23121 RVA: 0x0026F708 File Offset: 0x0026D908
	private ebe(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005A52 RID: 23122 RVA: 0x0026F714 File Offset: 0x0026D914
	public ebe()
	{
	}

	// Token: 0x06005A53 RID: 23123 RVA: 0x0026F720 File Offset: 0x0026D920
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			c5x c5x = A_1 as c5x;
			c5x c5x2 = A_0 as c5x;
			if (c5x2 != null && c5x2.IsPlayer)
			{
				if (!string.IsNullOrEmpty(c5x2.h.b.aa().CustomProperties.GetClassPropertyValue<string>(ddm.a)))
				{
					string text = "Вы не можете управлять чем-либо с этими когтями";
					a7v.a(new h0(text + ".", new Color?(adi.m)));
					bmj.a(c5x2, new d53(text, Color.Red, null, false));
					return;
				}
				if (c5x2.h.b.aa().Vehicle != null)
				{
					string text2 = "Надеюсь вы уже управляли";
					a7v.a(new h0(text2 + ".", new Color?(adi.m)));
					bmj.a(c5x2, new d53(text2, Color.Red, null, false));
					return;
				}
			}
			if (c5x2 != null && c5x2.IsPlayer && c5x != null && c5x.o.b != null && (c5x2.h.b.am() == bln.a || c5x2.h.b.am() == bln.b))
			{
				c5x c5x3 = vq.a("creatures\\machines\\Dreadnought", false);
				if (c5x3 != null)
				{
					amc aspect = c5x3.GetAspect<amc>();
					if (aspect != null)
					{
						c5x2.h.b.aa().CustomProperties["StoredHealth"] = c5x2.h.b.aa().Defense.q().zo();
						c5x2.h.b.aa().CustomProperties["StoredPortrait"] = c5x2.h.b.aa().Portrait;
						c5x2.h.b.aa().a(true);
						c5x2.h.b.aa().Gear.l().a(aspect.aa().Gear.l().Item.fy() as c8d, true);
						this.a(c5x2.h.b.aa().Gear.l().Item.Definition);
						c5x2.h.b.aa().Gear.j()[WeaponKey.Primary].a(aspect.aa().Gear.j()[WeaponKey.Primary].Item.fy() as cd1, true);
						this.a(c5x2.h.b.aa().Gear.j()[WeaponKey.Primary].Item.Definition);
						c5x2.h.b.aa().Gear.j()[WeaponKey.Secondary].a(aspect.aa().Gear.j()[WeaponKey.Secondary].Item.fy() as cd1, true);
						this.a(c5x2.h.b.aa().Gear.j()[WeaponKey.Secondary].Item.Definition);
						c5x2.h.b.aa().Gear.d()[0].po(new acz(new LibraryItemDefinitionProvider<cdk>("Tokens\\ShootDreadnoughtRocketToken")));
						c5x2.h.b.aa().Gear.d()[5].po(new acz(new LibraryItemDefinitionProvider<cdk>("Tokens\\DismountDreadnoughtToken")));
						c5x2.h.b.aa().AttributesBase &= ~d8o.b;
						c5x2.h.b.aa().AttributesBase &= ~d8o.c;
						c5x2.h.b.aa().AttributesBase |= d8o.e;
						c5x2.h.b.aa().ImmunitiesBase |= CharacterImmunities.Caltrops;
						serviceOrThrow.aqu().r()[qu.b] = true;
						serviceOrThrow.aqu().r()[qu.a] = true;
						c5x2.h.b.a(bln.fc);
						c5x2.h.b.aa().Portrait = "power_suit";
						c5x2.h.b.a(ai5.g);
						c5x2.h.b.aa().CustomProperties[ddm.b] = true;
						c5x2.h.b.aa().CustomProperties[ddm.f] = true;
						c5x2.h.b.ay().Add(new bfq("WheeledBot1Explosion"));
						List<cze> list = c5x2.h.b.ay();
						e01 e = new e01();
						e.a("ExplosionMedium");
						e.a(true);
						e.b(false);
						list.Add(e);
						c5x2.h.b.ay().Add(new bfq("WheeledBot1Rumble"));
						c5x2.Size = new Vector3(1f, 1f, 2.25f);
						c5x2.Location = c5x.Location;
						c5x2.VisualDirection = a63.a((HorizontalDirection)c5x.o.b.b.Y);
						c5x2.ah();
						c5x2.h.b.aa().StatusEffects.a(new ex(), false, false, false);
						a3f aspect2 = c5x.GetAspect<a3f>();
						if (aspect2 != null)
						{
							float? primitivePropertyValue = aspect2.a().GetPrimitivePropertyValue<float>("StoredHealth", null);
							if (primitivePropertyValue != null)
							{
								c5x2.h.b.aa().Defense.q().zp(primitivePropertyValue.Value);
							}
							else
							{
								c5x2.h.b.aa().Defense.q().zp(c5x2.h.b.aa().Defense.q().zm());
							}
						}
						else
						{
							c5x2.h.b.aa().Defense.q().zp(c5x2.h.b.aa().Defense.q().zm());
						}
						cix cix = c5x2.Zone.ActionManager;
						a4s a4s = new a4s(new uk(), null, null, null);
						a4s.b(new ar7(c5x));
						cix.g9(a4s, atp.a);
						c5x2.c().a("DreadnoughtMount");
						c5x2.c().a("engine", "DreadnoughtEngine", 1f, c9z.b, true, false);
						awx awx = new awx();
						awx.a(m7.b);
						awx.ad().Add(new e4t(c5x2.h.b, CharacterState.Custom3, dz6.b(cux.a), 0, null, 1));
						c5x2.i.b.b(awx, atp.a);
						d60 d = c5x2.Zone.a();
						if (d != null)
						{
							foreach (b0b b0b in d.ab4(new string[]
							{
								"dreadnoughtBarricade"
							}))
							{
								b0b.TileFormationModifiers.s3(1);
								b0b.z();
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005A54 RID: 23124 RVA: 0x0026FF24 File Offset: 0x0026E124
	private void a(bk3 A_0)
	{
		if (!string.IsNullOrEmpty(A_0.az()) && A_0.az().Length > 1)
		{
			A_0.g(A_0.az().Substring(0, A_0.az().Length - 1));
		}
	}
}
