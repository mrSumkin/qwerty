using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common;

// Token: 0x0200053A RID: 1338
[eiz("CDE")]
[Serializable]
public sealed class f8 : aeq, b2h, ISerializable
{
	// Token: 0x0600223D RID: 8765 RVA: 0x000B54B4 File Offset: 0x000B36B4
	private f8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("CDE:SH");
	}

	// Token: 0x0600223E RID: 8766 RVA: 0x000B54D0 File Offset: 0x000B36D0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CDE:SH", this.a);
	}

	// Token: 0x0600223F RID: 8767 RVA: 0x000B54EC File Offset: 0x000B36EC
	public bool c()
	{
		return this.a;
	}

	// Token: 0x06002240 RID: 8768 RVA: 0x000B54F4 File Offset: 0x000B36F4
	public f8(ap9 A_0, bool A_1 = false) : base(A_0)
	{
		this.a = A_1;
	}

	// Token: 0x06002241 RID: 8769 RVA: 0x000B5504 File Offset: 0x000B3704
	public bool a()
	{
		return false;
	}

	// Token: 0x06002242 RID: 8770 RVA: 0x000B5508 File Offset: 0x000B3708
	public List<string> b()
	{
		return new List<string>
		{
			TimelapseTextFeeds.Combat.ToString()
		};
	}

	// Token: 0x06002243 RID: 8771 RVA: 0x000B5530 File Offset: 0x000B3730
	public ecs se()
	{
		ecs ecs = new ecs();
		dl6 dl = new dl6();
		ecs.a.Add(dl);
		if (this.a)
		{
			dl.a.Add(new bph(bvm.a(Color.Red), string.Format("- {0} разбивается! ", (base.h() != null) ? base.h().a : base.i()), null));
			return ecs;
		}
		bool flag = (!base.h().c && (base.h().g & d8o.e) == d8o.a) || (base.h().g & d8o.b) > d8o.a;
		dl.a.Add(new bph(bvm.a(Color.Red), string.Format("- {0} {1}. ", (base.h() != null) ? base.h().a : base.i(), flag ? "погибает" : "разрушается"), null));
		return ecs;
	}

	// Token: 0x04001471 RID: 5233
	private bool a;
}
