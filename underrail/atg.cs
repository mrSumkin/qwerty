using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02001279 RID: 4729
[a(typeof(bdf))]
[eiz("TWLSEA")]
[Serializable]
public sealed class atg : bdf
{
	// Token: 0x060066AB RID: 26283 RVA: 0x002BA0EC File Offset: 0x002B82EC
	private atg(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("TWLSEA:IVC", typeof(ae4)) as ae4);
	}

	// Token: 0x060066AC RID: 26284 RVA: 0x002BA124 File Offset: 0x002B8324
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TWLSEA:IVC", this.a);
	}

	// Token: 0x060066AD RID: 26285 RVA: 0x002BA140 File Offset: 0x002B8340
	public atg(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x060066AE RID: 26286 RVA: 0x002BA154 File Offset: 0x002B8354
	public bool a()
	{
		if (base.f() != null && base.f().ao() != null)
		{
			amc b = ((c5x)base.f().ao()).h.b;
			if (b != null)
			{
				return b.af() == CharacterState.Move;
			}
		}
		return false;
	}

	// Token: 0x060066AF RID: 26287 RVA: 0x002BA1A8 File Offset: 0x002B83A8
	public override void r7(eds A_0)
	{
		base.r7(A_0);
		if (base.a8() != null && base.f() != null && base.f().ao() != null)
		{
			amc aspect = base.f().ao().GetAspect<amc>();
			if (aspect != null)
			{
				base.a(aspect.aa().MovementSpeed * aju.d * 1.1f);
				base.a(base.h() * 1.35f);
				base.b(3.5);
				if (dz6.e() && dz6.a() != null)
				{
					base.a(base.h() / dz6.a().Value);
					base.b(base.d() / (double)dz6.a().Value);
				}
			}
			aw1.b(base.a8(), base.f().ao(), true);
		}
		if (!this.a())
		{
			this.a.a(base.a8(), bws.b, A_0.b.TotalMilliseconds);
		}
	}

	// Token: 0x060066B0 RID: 26288 RVA: 0x002BA2C8 File Offset: 0x002B84C8
	public override void r8(c5x A_0, bool A_1 = false)
	{
		base.r8(A_0, false);
		if (base.a8() != null && base.f() != null && base.f().ao() != null)
		{
			c5x c5x = (c5x)base.f().ao();
			c5x.d().a()[bah.c] = new ar7(base.a8());
			if (c5x.h.b != null && c5x.h.b.aa().Vehicle != null)
			{
				c5x.h.b.aa().Vehicle.k();
			}
			if (!A_1)
			{
				base.a8().c().a("xpbl_JetSkiTowAttach");
				bmj.a(base.a8(), new d53("Подсоединено!", adi.h, null, false));
			}
		}
	}

	// Token: 0x060066B1 RID: 26289 RVA: 0x002BA3B0 File Offset: 0x002B85B0
	public override void r9(bool A_0 = false)
	{
		if (base.f() != null && base.f().ao() != null)
		{
			c5x c5x = (c5x)base.f().ao();
			c5x.d().a().RemoveProperty(bah.c);
			if (c5x.h.b != null && c5x.h.b.aa().Vehicle != null)
			{
				c5x.h.b.aa().Vehicle.k();
			}
			if (!A_0)
			{
				base.a8().c().a("xpbl_JetSkiTowDettach");
				bmj.a(base.a8(), new d53("Отсоединено!", adi.h, null, false));
			}
		}
		base.r9(false);
	}

	// Token: 0x04002A99 RID: 10905
	private ae4 a = new ae4();
}
