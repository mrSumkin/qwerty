using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Common;

// Token: 0x02000502 RID: 1282
[eiz("VRDE")]
[Serializable]
public sealed class etk : bjs, b2h, ISerializable
{
	// Token: 0x06002125 RID: 8485 RVA: 0x000B175C File Offset: 0x000AF95C
	private etk(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<csk>("VRDE:D", ref this.a, A_0);
		this.b = (cwt)A_0.GetValue("VRDE:AR", typeof(cwt));
	}

	// Token: 0x06002126 RID: 8486 RVA: 0x000B1798 File Offset: 0x000AF998
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<csk>("VRDE:D", this.a, info);
		info.AddValue("VRDE:AR", this.b);
	}

	// Token: 0x06002127 RID: 8487 RVA: 0x000B17C4 File Offset: 0x000AF9C4
	public cwt c()
	{
		return this.b;
	}

	// Token: 0x06002128 RID: 8488 RVA: 0x000B17CC File Offset: 0x000AF9CC
	public List<csk> d()
	{
		return this.a;
	}

	// Token: 0x06002129 RID: 8489 RVA: 0x000B17D4 File Offset: 0x000AF9D4
	public etk(cwt A_0, List<csk> A_1) : base((A_0 != null) ? A_0.j : null, (A_0 != null) ? A_0.i : null)
	{
		this.a = A_1;
		this.b = A_0;
	}

	// Token: 0x0600212A RID: 8490 RVA: 0x000B1814 File Offset: 0x000AFA14
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

	// Token: 0x0600212B RID: 8491 RVA: 0x000B185C File Offset: 0x000AFA5C
	public ecs se()
	{
		if (this.b == null)
		{
			return null;
		}
		ecs ecs = new ecs();
		dl6 dl = new dl6();
		ecs.a.Add(dl);
		dl.a.Add(new bph(bvm.a(), string.Format("- {0} броня транспорта поглощает ", (base.h() != null) ? base.h().a() : base.i()), null));
		bjs.a(dl, this.a);
		dl.a.Add(new bph(bvm.a(), string.Format("{0}.", (!string.IsNullOrEmpty(this.b.v)) ? (" (" + this.b.v + ")") : ""), null));
		return ecs;
	}

	// Token: 0x04001442 RID: 5186
	private new List<csk> a;

	// Token: 0x04001443 RID: 5187
	private new cwt b;
}
