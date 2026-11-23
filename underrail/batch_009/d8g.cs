using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020010ED RID: 4333
[eiz("S49")]
[Serializable]
public sealed class d8g : cze, ISerializable
{
	// Token: 0x06005B9E RID: 23454 RVA: 0x00275120 File Offset: 0x00273320
	private d8g(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("S49:C", typeof(ar7)) as ar7);
		this.b = (A_0.GetValue("S49:S", typeof(ar7)) as ar7);
		this.c = (A_0.GetValue("S49:L", typeof(bt4)) as bt4);
		if (ell.a() >= 160)
		{
			this.d = (A_0.GetValue("S49:D", typeof(a1q?)) as a1q?);
			this.e = A_0.GetBoolean("S49:N");
		}
		else
		{
			this.e = true;
		}
		if (ell.a() >= 231)
		{
			this.f = (A_0.GetValue("S49:E", typeof(Guid?)) as Guid?);
		}
		if (ell.a() >= 231)
		{
			this.g = A_0.GetString("S49:U");
		}
		if (ell.a() >= 494)
		{
			this.h = A_0.GetString("S49:R");
			this.i = (A_0.GetValue("S49:T", typeof(int?)) as int?);
		}
	}

	// Token: 0x06005B9F RID: 23455 RVA: 0x00275280 File Offset: 0x00273480
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("S49:C", this.a);
		info.AddValue("S49:S", this.b);
		info.AddValue("S49:L", this.c);
		info.AddValue("S49:D", this.d);
		info.AddValue("S49:N", this.e);
		info.AddValue("S49:E", this.f);
		info.AddValue("S49:U", this.g);
		info.AddValue("S49:R", this.h);
		info.AddValue("S49:T", this.i);
	}

	// Token: 0x06005BA0 RID: 23456 RVA: 0x00275340 File Offset: 0x00273540
	public d8g(b0b A_0, b0b A_1, bt4 A_2, a1q? A_3 = null, bool A_4 = true, Guid? A_5 = null, string A_6 = null, string A_7 = null, int? A_8 = null)
	{
		this.a = new ar7(A_0);
		this.b = new ar7(A_1);
		this.c = A_2;
		this.e = A_4;
		this.d = A_3;
		this.f = A_5;
		this.g = A_6;
		this.h = A_7;
		this.i = A_8;
	}

	// Token: 0x06005BA1 RID: 23457 RVA: 0x002753A4 File Offset: 0x002735A4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (this.b != null && this.b.ao() != null && this.b.ao().Zone != null && this.c != null)
		{
			c5k c5k = bpo.GetServiceOrThrow<d6j>().dv().a("locale\\creature\\psionicDoppelganger");
			if (c5k != null)
			{
				c5x c5x = c5k.a(null, false) as c5x;
				if (c5x != null)
				{
					aud aud;
					Vector3 a_;
					this.c.a(this.b.ao().Zone, out aud, out a_);
					c5x.Location = a_;
					c5x.Layer = aju.x;
					if (c5x.h.b != null)
					{
						c5x.h.b.aa().StatusEffects.a(new dlo((this.i != null) ? this.i.Value : (d0u.b * 5)), false, false, false);
						c5x.h.b.aa().FactionId = asp.d;
						if (this.a != null)
						{
							c5x c5x2 = this.a.ao() as c5x;
							if (c5x2 != null && c5x2.IsPlayer)
							{
								c5x.h.b.aa().CustomProperties["IsPlayerCreatedDoppelganger"] = true;
							}
						}
						amc amc = ((c5x)this.b.ao()).h.b;
						if (amc != null)
						{
							c5x.h.b.a(amc.am());
							c5x.h.b.aa().Gender = amc.aa().Gender;
							if (amc.aa().Gear.l().Item != null)
							{
								c5x.h.b.aa().Gear.l().Item.fu().a(amc.aa().Gear.l().Item.fu().e());
							}
						}
						if (c5x.t.b != null)
						{
							c5x.t.b.y6()[ddq.a6] = true;
							c5x.t.b.y6()[ddq.a3] = ((this.f != null) ? this.f.Value : this.b.ao().qe());
						}
						if (this.d != null && c5x.h.b.aa().Gear.j()[WeaponKey.Primary].Item != null)
						{
							c5x.h.b.aa().Gear.j()[WeaponKey.Primary].Item.TypedDefinition.l().Clear();
							c5x.h.b.aa().Gear.j()[WeaponKey.Primary].Item.TypedDefinition.l().Add(this.d.Value);
							c5x.h.b.aa().bl();
						}
					}
					c5x.VisualDirection = (HorizontalDirection)cuo.a.Next(8);
					if (!string.IsNullOrEmpty(this.g))
					{
						c5x.q(this.g);
						c5x.h.b.aa().Name = this.g;
					}
					if (!string.IsNullOrEmpty(this.h))
					{
						c5x.b(this.h);
					}
					aud.a(c5x);
					if (this.e)
					{
						((c5x)this.b.ao()).c().a(Guid.NewGuid().ToString(), "DarkSecretReveal", 1f, c9z.a, false, false);
					}
				}
			}
		}
	}

	// Token: 0x04002494 RID: 9364
	private new ar7 a;

	// Token: 0x04002495 RID: 9365
	private ar7 b;

	// Token: 0x04002496 RID: 9366
	private bt4 c;

	// Token: 0x04002497 RID: 9367
	private a1q? d;

	// Token: 0x04002498 RID: 9368
	private bool e;

	// Token: 0x04002499 RID: 9369
	private Guid? f;

	// Token: 0x0400249A RID: 9370
	private string g;

	// Token: 0x0400249B RID: 9371
	private string h;

	// Token: 0x0400249C RID: 9372
	private int? i;
}
