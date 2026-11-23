using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001036 RID: 4150
[eiz("ABNV")]
[Serializable]
public sealed class an9 : cze
{
	// Token: 0x060055B6 RID: 21942 RVA: 0x0025C528 File Offset: 0x0025A728
	private an9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060055B7 RID: 21943 RVA: 0x0025C534 File Offset: 0x0025A734
	public an9()
	{
	}

	// Token: 0x060055B8 RID: 21944 RVA: 0x0025C540 File Offset: 0x0025A740
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_0 as c5x;
		if (c5x != null && c5x.h.b != null)
		{
			ar7 classPropertyValue = c5x.d().a().GetClassPropertyValue<ar7>(bah.c);
			if (classPropertyValue != null && classPropertyValue.ao() != null)
			{
				bdf aspect = classPropertyValue.ao().GetAspect<bdf>();
				if (aspect != null && aspect.f() != null && aspect.f().ao() == c5x)
				{
					aspect.r9(false);
				}
			}
			c5x.h.b.aa().Vehicle.a(null);
			ckc ckc = Enumerable.FirstOrDefault<ckc>(c5x.h.b.aa().StatusEffects.Get<ckc>());
			if (ckc != null)
			{
				c5x.h.b.aa().StatusEffects.d(ckc);
			}
			c5x c5x2 = new c5x();
			c5x2.Size = new Vector3(1f, 1f, 1f);
			c5x2.VisualDirection = c5x.VisualDirection;
			c5x2.Location = c5x.Location;
			c5x2.x = true;
			c5x2.y = true;
			c5x2.TileFormationModifiers.s3(1);
			c5x2.Layer = aju.x;
			c5x2.z = new Vector2?(new Vector2(1f, 1f));
			if (c5x.IsPlayer)
			{
				c5x2.a(dm9.a);
			}
			etz etz = new etz(c5x2);
			etz.a = "Objects\\Vehicles\\Ridable\\" + c5x.h.b.aa().Vehicle.ah();
			etz.d(225);
			etz.c(8);
			etz.a(true);
			c5x2.SetAspect<cd0>(etz);
			wv wv = new wv(c5x2);
			wv.c(c5x.h.b.aa().Vehicle.ah() + "_Open");
			wv.d(c5x.h.b.aa().Vehicle.ah() + "_Close");
			wv.a(c5x.h.b.aa().Vehicle);
			wv.c(2.5f);
			wv.af2(true);
			wv.ps(d98.f);
			c5x2.SetAspect<bim>(wv);
			ay2 aspect2 = new ay2(c5x2);
			c5x2.SetAspect<bbw>(aspect2);
			if (!string.IsNullOrEmpty(wv.g().f()) || wv.g().z() > 0)
			{
				d2b d2b = new d2b(c5x2);
				d2b.b(wv.g().f());
				d2b.a(wv.g().z());
				d2b.d(true);
				c5x2.SetAspect<d2b>(d2b);
			}
			if (wv.g().l().Count > 0)
			{
				wv.a(c44.e);
				c3g c3g = new c3g(c5x2);
				c3g.d().AddRange(wv.g().l());
				c5x2.SetAspect<c3g>(c3g);
			}
			c5x.Area.a(c5x2);
			if (c5x.h.b.aa().SpecialAbilities.a(typeof(d5e)))
			{
				c5x.h.b.aa().SpecialAbilities.a(dgk.Get<d5e>());
			}
			c5x.h.b.aa().AttributesBase &= ~c5x.h.b.aa().Vehicle.s();
			c5x.h.b.aa().Vehicle = null;
			c8d c8d = c5x.h.b.aa().CustomProperties.GetClassPropertyValue<coh>(ddm.h) as c8d;
			if (c8d != null)
			{
				c5x.h.b.aa().Gear.l().a(c8d, true);
			}
			if (c5x.h.b.aa() is e3q)
			{
				foreach (WeaponKey key in new WeaponKey[]
				{
					WeaponKey.Primary,
					WeaponKey.Secondary
				})
				{
					Guid? primitivePropertyValue = c5x.h.b.aa().CustomProperties.GetPrimitivePropertyValue<Guid>("vehicleRidingWeaponUnequipped_" + key.ToString(), null);
					if (primitivePropertyValue != null)
					{
						if (c5x.h.b.aa().Gear.j()[key].Item == null)
						{
							cd1 cd = c5x.h.b.aa().Bag.a(primitivePropertyValue.Value) as cd1;
							if (cd != null)
							{
								c5x.h.b.aa().Bag.z5(cd);
								c5x.h.b.aa().Gear.j()[key].a(cd, true);
							}
						}
						c5x.h.b.aa().CustomProperties.RemoveProperty("vehicleRidingWeaponUnequipped_" + key.ToString());
					}
				}
			}
			c5x.h.b.aa().bl();
			c5x.h.b.at();
			wv.g().k();
			if (dz6.e())
			{
				d02 service = bpo.GetService<d02>();
				if (service != null)
				{
					d4n d4n = service.ahu(c5x.h.b.aa());
					if (d4n != null && service.ahe() == d4n)
					{
						d4n.d = (double)(d4n.b.aa().Offense.m() / 2);
					}
				}
			}
		}
	}
}
