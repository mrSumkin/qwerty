using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Generators.Items;

// Token: 0x02001086 RID: 4230
[eiz("DCCWJ")]
[Serializable]
public sealed class lt : cze, ISerializable
{
	// Token: 0x06005832 RID: 22578 RVA: 0x00264EB0 File Offset: 0x002630B0
	private lt(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.c = (Guid?)A_0.GetValue("DCCWJ:I", typeof(Guid?));
		this.d = A_0.GetString("DCCWJ:A");
		this.a = (Point)A_0.GetValue("DCCWJ:L", typeof(Point));
		this.b = (HorizontalDirection)A_0.GetValue("DCCWJ:D", typeof(HorizontalDirection));
	}

	// Token: 0x06005833 RID: 22579 RVA: 0x00264F38 File Offset: 0x00263138
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DCCWJ:I", this.c);
		info.AddValue("DCCWJ:A", this.d);
		info.AddValue("DCCWJ:L", this.a);
		info.AddValue("DCCWJ:D", this.b);
	}

	// Token: 0x06005834 RID: 22580 RVA: 0x00264FA0 File Offset: 0x002631A0
	public Point d()
	{
		return this.a;
	}

	// Token: 0x06005835 RID: 22581 RVA: 0x00264FA8 File Offset: 0x002631A8
	public void a(Point A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005836 RID: 22582 RVA: 0x00264FB4 File Offset: 0x002631B4
	public HorizontalDirection c()
	{
		return this.b;
	}

	// Token: 0x06005837 RID: 22583 RVA: 0x00264FBC File Offset: 0x002631BC
	public void a(HorizontalDirection A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005838 RID: 22584 RVA: 0x00264FC8 File Offset: 0x002631C8
	public string a()
	{
		return this.d;
	}

	// Token: 0x06005839 RID: 22585 RVA: 0x00264FD0 File Offset: 0x002631D0
	public void a(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600583A RID: 22586 RVA: 0x00264FDC File Offset: 0x002631DC
	public Guid? b()
	{
		return this.c;
	}

	// Token: 0x0600583B RID: 22587 RVA: 0x00264FE4 File Offset: 0x002631E4
	public void a(Guid? A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600583C RID: 22588 RVA: 0x00264FF0 File Offset: 0x002631F0
	public lt()
	{
	}

	// Token: 0x0600583D RID: 22589 RVA: 0x00264FF8 File Offset: 0x002631F8
	public sealed override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		if (this.c != null)
		{
			aud aud = null;
			if (this.d != null)
			{
				if (A_1 != null)
				{
					aud = A_1.Zone.n(this.d);
				}
				else if (A_0 != null)
				{
					aud = A_0.Zone.n(this.d);
				}
			}
			else if (A_1 != null)
			{
				aud = A_1.Area;
			}
			if (aud != null)
			{
				c5x = (new ar7(this.c.Value, aud).ao() as c5x);
			}
		}
		else
		{
			c5x = (A_1 as c5x);
		}
		if (c5x != null && c5x.h.b != null && c5x.h.b.aa().Gear.j()[c5x.h.b.aa().Offense.au()].Item != null)
		{
			coh coh = c5x.h.b.aa().Gear.j()[c5x.h.b.aa().Offense.au()].Item;
			c5x.h.b.aa().Gear.j()[c5x.h.b.aa().Offense.au()].a(null, true);
			c5x c5x2 = new c5x();
			c5x2.q(coh.Definition.az());
			c5x2.Layer = aju.x;
			c5x2.Size = new Vector3(1f, 1f, 0.1f);
			c5x2.IsGround = true;
			c5x2.x = true;
			c5x2.Location = this.a.a();
			c5x2.SetAspect<cd0>(new a2o(c5x2)
			{
				a = "Projectiles\\Xpbl_Spear"
			});
			mk mk = new mk();
			mk.StaticItems.z3(coh, true);
			mk.GiveTo = bvl.b;
			mk.AutoEquipMode = new AutoEquipMode?(AutoEquipMode.FreeSlot);
			bim bim = new bim(c5x2);
			bim.s().Add(mk);
			List<cze> list = bim.s();
			uk uk = new uk();
			uk.a(bvl.c);
			list.Add(uk);
			bim.af2(true);
			bim.ps(d98.g);
			c5x2.SetAspect<bim>(bim);
			c5x2.VisualDirection = this.b;
			c5x2.b("thrownSpear");
			c5x.Area.a(c5x2);
		}
	}

	// Token: 0x04002393 RID: 9107
	private new Point a;

	// Token: 0x04002394 RID: 9108
	private HorizontalDirection b;

	// Token: 0x04002395 RID: 9109
	private Guid? c;

	// Token: 0x04002396 RID: 9110
	private string d;
}
