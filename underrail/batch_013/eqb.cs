using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Common;

// Token: 0x020004FD RID: 1277
[eiz("CBDE")]
[Serializable]
public sealed class eqb : bjs, b2h, ISerializable
{
	// Token: 0x0600210C RID: 8460 RVA: 0x000B121C File Offset: 0x000AF41C
	private eqb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<csk>("CBDE:D", ref this.a, A_0);
		this.b = (cwt)A_0.GetValue("CBDE:AR", typeof(cwt));
	}

	// Token: 0x0600210D RID: 8461 RVA: 0x000B1258 File Offset: 0x000AF458
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<csk>("CBDE:D", this.a, info);
		info.AddValue("CBDE:AR", this.b);
	}

	// Token: 0x0600210E RID: 8462 RVA: 0x000B1284 File Offset: 0x000AF484
	public cwt c()
	{
		return this.b;
	}

	// Token: 0x0600210F RID: 8463 RVA: 0x000B128C File Offset: 0x000AF48C
	public List<csk> d()
	{
		return this.a;
	}

	// Token: 0x06002110 RID: 8464 RVA: 0x000B1294 File Offset: 0x000AF494
	public eqb(cwt A_0, List<csk> A_1) : base((A_0 != null) ? A_0.j : null, (A_0 != null) ? A_0.i : null)
	{
		this.a = A_1;
		this.b = A_0;
	}

	// Token: 0x06002111 RID: 8465 RVA: 0x000B12D4 File Offset: 0x000AF4D4
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

	// Token: 0x06002112 RID: 8466 RVA: 0x000B131C File Offset: 0x000AF51C
	public ecs se()
	{
		if (this.b == null)
		{
			return null;
		}
		ecs ecs = new ecs();
		dl6 dl = new dl6();
		ecs.a.Add(dl);
		dl.a.Add(new bph(bvm.a(), string.Format("- {0} блокирует ", (base.h() != null) ? base.h().a() : base.i()), null));
		bjs.a(dl, this.a);
		dl.a.Add(new bph(bvm.a(), string.Format("{0}.", (!string.IsNullOrEmpty(this.b.v)) ? (" (" + this.b.v + ")") : ""), null));
		return ecs;
	}

	// Token: 0x0400143C RID: 5180
	private new List<csk> a;

	// Token: 0x0400143D RID: 5181
	private new cwt b;
}
