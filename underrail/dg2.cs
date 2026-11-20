using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;
using Ouroboros.Playfield.Lightning;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x020012B6 RID: 4790
[eiz("LSEA")]
[Serializable]
public sealed class dg2 : Aspect<c5x>, ISerializable
{
	// Token: 0x06006960 RID: 26976 RVA: 0x002C6FB8 File Offset: 0x002C51B8
	private dg2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("LSEA:C", typeof(dth)) as dth);
		this.b = A_0.GetString("LSEA:B");
		this.c = A_0.GetString("LSEA:F");
		this.d = A_0.GetBoolean("LSEA:D");
		if (ell.a() >= 405)
		{
			di7.ReadList<string>("LSEA:R", ref this.e, A_0);
			return;
		}
		this.e = new List<string>();
	}

	// Token: 0x06006961 RID: 26977 RVA: 0x002C7064 File Offset: 0x002C5264
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("LSEA:C", this.a);
		info.AddValue("LSEA:B", this.b);
		info.AddValue("LSEA:F", this.c);
		info.AddValue("LSEA:D", this.d);
		di7.WriteList<string>("LSEA:R", this.e, info);
	}

	// Token: 0x06006962 RID: 26978 RVA: 0x002C70D0 File Offset: 0x002C52D0
	public string e()
	{
		return this.c;
	}

	// Token: 0x06006963 RID: 26979 RVA: 0x002C70D8 File Offset: 0x002C52D8
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06006964 RID: 26980 RVA: 0x002C70E4 File Offset: 0x002C52E4
	public dth f()
	{
		return this.a;
	}

	// Token: 0x06006965 RID: 26981 RVA: 0x002C70EC File Offset: 0x002C52EC
	public void a(dth A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006966 RID: 26982 RVA: 0x002C70F8 File Offset: 0x002C52F8
	public string d()
	{
		return this.b;
	}

	// Token: 0x06006967 RID: 26983 RVA: 0x002C7100 File Offset: 0x002C5300
	public void b(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006968 RID: 26984 RVA: 0x002C710C File Offset: 0x002C530C
	public bool b()
	{
		return this.d;
	}

	// Token: 0x06006969 RID: 26985 RVA: 0x002C7114 File Offset: 0x002C5314
	public void a(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600696A RID: 26986 RVA: 0x002C7120 File Offset: 0x002C5320
	public List<string> a()
	{
		return this.e;
	}

	// Token: 0x0600696B RID: 26987 RVA: 0x002C7128 File Offset: 0x002C5328
	public void a(List<string> A_0)
	{
		this.e = A_0;
	}

	// Token: 0x0600696C RID: 26988 RVA: 0x002C7134 File Offset: 0x002C5334
	public dg2(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x0600696D RID: 26989 RVA: 0x002C7158 File Offset: 0x002C5358
	public void b(int A_0 = 0)
	{
		if (base.a8() != null && base.a8().a() && (this.a == null || this.a.jh(base.a8())))
		{
			this.a(A_0);
		}
	}

	// Token: 0x0600696E RID: 26990 RVA: 0x002C71AC File Offset: 0x002C53AC
	private bool a(int A_0 = 0)
	{
		if (base.a8() == null || base.a8().Area == null || base.a8().Zone == null)
		{
			return false;
		}
		c1a a_ = base.a8().Zone;
		aud aud = base.a8().Area;
		Vector3 a_2 = base.a8().Location;
		HorizontalDirection a_3 = base.a8().VisualDirection;
		c5x c5x = vq.a("creatures\\Machines\\Xpbl\\" + this.b, a_, new bt4(aud.y8(), a_2), false);
		if (c5x != null)
		{
			base.a8().w();
			base.a8().an();
			c5x.VisualDirection = a_3;
			if (c5x.h.b != null && c5x.i.b != null && c5x.t.b != null)
			{
				if (this.d)
				{
					amc amc = c5x.h.b;
					amc.a(amc.am() + "d");
				}
				c5x.t.b.a(false);
				c5x.h.b.ap = new CharacterState?(CharacterState.Custom2);
				c5x.h.b.aq = new int?(0);
				c5x.h.b.aa().FactionId = this.c;
				if (A_0 > 0)
				{
					if ((float)A_0 >= c5x.h.b.aa().Defense.q().zm())
					{
						c5x.h.b.aa().a(null, null, false);
						return false;
					}
					c5x.h.b.aa().Defense.q().zp(Math.Max(1f, c5x.h.b.aa().Defense.q().zo() - (float)A_0));
				}
				c5x.c().a("Xpbl_LemurianStatueActivation_" + c5x.y8().Replace(" ", ""));
				awx awx = new awx();
				awx.b(false);
				awx.c(false);
				awx.a(false);
				awx.ad().Add(new e4t(c5x.h.b, CharacterState.Custom2, dz6.b(100), 0, null, 1));
				awx.ad().Add(new a4s(new epw(null), null, new ar7(c5x), null));
				awx.ad().Add(new a4s(new b16(null), null, new ar7(c5x), null));
				awx.ad().Add(new a4s(new clv(true), null, new ar7(c5x), null));
				c5x.i.b.b(awx, atp.a);
			}
			foreach (string a_4 in this.e)
			{
				c5x.b(a_4);
			}
			new ah7("LemurianServantLight", null)
			{
				Layer = aju.x,
				Light = new ae8(new Color(106, 243, 242), 0.25f, LightType.Increment),
				LightFadeRate = 0.08f,
				Range = 4f
			}.g().be(c5x);
			return true;
		}
		return false;
	}

	// Token: 0x04002B6F RID: 11119
	private dth a;

	// Token: 0x04002B70 RID: 11120
	private string b;

	// Token: 0x04002B71 RID: 11121
	private string c = asp.@as;

	// Token: 0x04002B72 RID: 11122
	private bool d;

	// Token: 0x04002B73 RID: 11123
	private List<string> e = new List<string>();
}
