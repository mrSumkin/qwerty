using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Common;

// Token: 0x02000541 RID: 1345
[eiz("CLP")]
[Serializable]
public sealed class a5s : aeq, b2h, ISerializable
{
	// Token: 0x06002267 RID: 8807 RVA: 0x000B6060 File Offset: 0x000B4260
	private a5s(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("CLP:A");
	}

	// Token: 0x06002268 RID: 8808 RVA: 0x000B607C File Offset: 0x000B427C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CLP:A", this.a);
	}

	// Token: 0x06002269 RID: 8809 RVA: 0x000B6098 File Offset: 0x000B4298
	public a5s(ap9 A_0, int A_1) : base(A_0)
	{
		this.a = A_1;
	}

	// Token: 0x0600226A RID: 8810 RVA: 0x000B60A8 File Offset: 0x000B42A8
	public bool a()
	{
		return false;
	}

	// Token: 0x0600226B RID: 8811 RVA: 0x000B60B0 File Offset: 0x000B42B0
	public List<string> b()
	{
		return new List<string>
		{
			TimelapseTextFeeds.Chat.ToString(),
			TimelapseTextFeeds.Combat.ToString()
		};
	}

	// Token: 0x0600226C RID: 8812 RVA: 0x000B60EC File Offset: 0x000B42EC
	public ecs se()
	{
		if (base.h() != null && !string.IsNullOrEmpty(base.h().a))
		{
			ecs ecs = new ecs();
			dl6 dl = new dl6();
			dl.a.Add(new bph(bvm.a(), string.Format("- {0} теряет ", base.h()), null));
			dl.a.Add(new bph(bvm.a(adi.aa), this.a.ToString(), null));
			dl.a.Add(new bph(bvm.a(), " пси-очков.", null));
			ecs.a.Add(dl);
			return ecs;
		}
		return null;
	}

	// Token: 0x0400147B RID: 5243
	private int a;
}
