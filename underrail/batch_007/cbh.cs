using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Common;

// Token: 0x02000503 RID: 1283
[eiz("VTDE")]
[Serializable]
public sealed class cbh : bjs, b2h, ISerializable
{
	// Token: 0x0600212C RID: 8492 RVA: 0x000B1934 File Offset: 0x000AFB34
	private cbh(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<csk>("VTDE:D", ref this.a, A_0);
		this.b = (cwt)A_0.GetValue("VTDE:AR", typeof(cwt));
	}

	// Token: 0x0600212D RID: 8493 RVA: 0x000B1970 File Offset: 0x000AFB70
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<csk>("VTDE:D", this.a, info);
		info.AddValue("VTDE:AR", this.b);
	}

	// Token: 0x0600212E RID: 8494 RVA: 0x000B199C File Offset: 0x000AFB9C
	public cwt c()
	{
		return this.b;
	}

	// Token: 0x0600212F RID: 8495 RVA: 0x000B19A4 File Offset: 0x000AFBA4
	public List<csk> d()
	{
		return this.a;
	}

	// Token: 0x06002130 RID: 8496 RVA: 0x000B19AC File Offset: 0x000AFBAC
	public cbh(cwt A_0, List<csk> A_1) : base((A_0 != null) ? A_0.j : null, (A_0 != null) ? A_0.i : null)
	{
		this.a = A_1;
		this.b = A_0;
	}

	// Token: 0x06002131 RID: 8497 RVA: 0x000B19E8 File Offset: 0x000AFBE8
	public override List<string> b()
	{
		if (this.b != null && !this.b.u)
		{
			return new List<string>
			{
				TimelapseTextFeeds.Combat.ToString()
			};
		}
		return new List<string>();
	}

	// Token: 0x06002132 RID: 8498 RVA: 0x000B1A30 File Offset: 0x000AFC30
	public ecs se()
	{
		if (this.b == null)
		{
			return null;
		}
		ecs ecs = new ecs();
		dl6 dl = new dl6();
		ecs.a.Add(dl);
		string format;
		if (this.b.y != null)
		{
			format = "- " + this.b.y;
		}
		else
		{
			string str = this.b.e ? "наносит крит. цели" : "наносит цели";
			if (this.b.w)
			{
				format = "- {2} транспорт получает ";
			}
			else if (!string.IsNullOrEmpty(this.b.k))
			{
				format = "- {0}: {1} " + str + " {2} броня транспорта ";
			}
			else
			{
				format = "- {0} " + str + " {2} броня транспорта ";
			}
		}
		dl.a.Add(new bph(bvm.a(), string.Format(format, (base.f() != null) ? base.f().a() : base.i(), this.b.k, (base.h() != null) ? base.h().a() : base.i()), null));
		bjs.a(dl, this.a);
		dl.a.Add(new bph(bvm.a(), string.Format("{0}.", (!string.IsNullOrEmpty(this.b.v)) ? (" (" + this.b.v + ")") : ""), null));
		if (!string.IsNullOrEmpty(this.b.aj))
		{
			dl.a.Add(new bph(bvm.a(), " " + this.b.aj, null));
		}
		return ecs;
	}

	// Token: 0x04001444 RID: 5188
	private new List<csk> a;

	// Token: 0x04001445 RID: 5189
	private new cwt b;
}
