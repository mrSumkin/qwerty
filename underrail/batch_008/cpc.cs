using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Common;

// Token: 0x02000512 RID: 1298
[eiz("CIME")]
[Serializable]
public sealed class cpc : bjs, b2h, ISerializable
{
	// Token: 0x06002173 RID: 8563 RVA: 0x000B2A7C File Offset: 0x000B0C7C
	private cpc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (cwt)A_0.GetValue("CIME:AR", typeof(cwt));
			return;
		}
		if (base.GetType() == typeof(cpc))
		{
			this.a = (cwt)A_0.GetValue("_AttackResult", typeof(cwt));
			return;
		}
		this.a = (cwt)A_0.GetValue("CharacterIsMissedEvent+_AttackResult", typeof(cwt));
	}

	// Token: 0x06002174 RID: 8564 RVA: 0x000B2B18 File Offset: 0x000B0D18
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CIME:AR", this.a);
	}

	// Token: 0x06002175 RID: 8565 RVA: 0x000B2B34 File Offset: 0x000B0D34
	public cwt c()
	{
		return this.a;
	}

	// Token: 0x06002176 RID: 8566 RVA: 0x000B2B3C File Offset: 0x000B0D3C
	public cpc(cwt A_0) : base((A_0 != null) ? A_0.j : null, (A_0 != null) ? A_0.i : null)
	{
		this.a = A_0;
	}

	// Token: 0x06002177 RID: 8567 RVA: 0x000B2B74 File Offset: 0x000B0D74
	public override List<string> b()
	{
		if (this.a != null && !this.a.u)
		{
			return new List<string>
			{
				TimelapseTextFeeds.Combat.ToString()
			};
		}
		return new List<string>();
	}

	// Token: 0x06002178 RID: 8568 RVA: 0x000B2BBC File Offset: 0x000B0DBC
	public ecs se()
	{
		if (this.a == null)
		{
			return null;
		}
		ecs ecs = new ecs();
		dl6 dl = new dl6();
		ecs.a.Add(dl);
		string format;
		if (!string.IsNullOrEmpty(this.a.k))
		{
			format = "- {0}: {1} не попадает в цель ({2}).";
		}
		else
		{
			format = "- {0} атакует цель ({2}), но промахивается.";
		}
		dl.a.Add(new bph(bvm.a(), string.Format(format, (base.f() != null) ? base.f().a() : base.i(), this.a.k, (base.h() != null) ? base.h().a() : base.i()), null));
		return ecs;
	}

	// Token: 0x0400144E RID: 5198
	private new cwt a;
}
