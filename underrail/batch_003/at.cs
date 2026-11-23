using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Common;

// Token: 0x0200053F RID: 1343
[eiz("CGP")]
[Serializable]
public sealed class at : aeq, b2h, ISerializable
{
	// Token: 0x0600225B RID: 8795 RVA: 0x000B5DEC File Offset: 0x000B3FEC
	private at(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("CGP:A");
	}

	// Token: 0x0600225C RID: 8796 RVA: 0x000B5E08 File Offset: 0x000B4008
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CGP:A", this.a);
	}

	// Token: 0x0600225D RID: 8797 RVA: 0x000B5E24 File Offset: 0x000B4024
	public at(ap9 A_0, int A_1) : base(A_0)
	{
		this.a = A_1;
	}

	// Token: 0x0600225E RID: 8798 RVA: 0x000B5E34 File Offset: 0x000B4034
	public bool a()
	{
		return false;
	}

	// Token: 0x0600225F RID: 8799 RVA: 0x000B5E38 File Offset: 0x000B4038
	public List<string> b()
	{
		return new List<string>
		{
			TimelapseTextFeeds.Chat.ToString(),
			TimelapseTextFeeds.Combat.ToString()
		};
	}

	// Token: 0x06002260 RID: 8800 RVA: 0x000B5E74 File Offset: 0x000B4074
	public ecs se()
	{
		if (base.h() != null && !string.IsNullOrEmpty(base.h().a))
		{
			ecs ecs = new ecs();
			dl6 dl = new dl6();
			dl.a.Add(new bph(bvm.a(), string.Format("- {0} получает ", base.h()), null));
			dl.a.Add(new bph(bvm.a(adi.z), this.a.ToString(), null));
			dl.a.Add(new bph(bvm.a(), " пси-очков.", null));
			ecs.a.Add(dl);
			return ecs;
		}
		return null;
	}

	// Token: 0x04001479 RID: 5241
	private int a;
}
