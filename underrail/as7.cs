using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02001294 RID: 4756
[a(typeof(bdf))]
[eiz("TWJSKIEAX")]
[Serializable]
public sealed class as7 : bdf
{
	// Token: 0x060067DB RID: 26587 RVA: 0x002BFBF4 File Offset: 0x002BDDF4
	private as7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060067DC RID: 26588 RVA: 0x002BFC00 File Offset: 0x002BDE00
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x060067DD RID: 26589 RVA: 0x002BFC0C File Offset: 0x002BDE0C
	public as7(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x060067DE RID: 26590 RVA: 0x002BFC18 File Offset: 0x002BDE18
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

	// Token: 0x060067DF RID: 26591 RVA: 0x002BFC6C File Offset: 0x002BDE6C
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
			if (base.a8().o.b != null)
			{
				base.a8().o.b.b.Y = base.a8().ac;
			}
		}
	}

	// Token: 0x060067E0 RID: 26592 RVA: 0x002BFDA0 File Offset: 0x002BDFA0
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

	// Token: 0x060067E1 RID: 26593 RVA: 0x002BFE88 File Offset: 0x002BE088
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
}
