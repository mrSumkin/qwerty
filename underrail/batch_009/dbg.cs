using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Common;

// Token: 0x0200053D RID: 1341
[eiz("CGPR")]
[Serializable]
public sealed class dbg : aeq, b2h, ISerializable
{
	// Token: 0x0600224F RID: 8783 RVA: 0x000B5890 File Offset: 0x000B3A90
	private dbg(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("CGPR:A");
	}

	// Token: 0x06002250 RID: 8784 RVA: 0x000B58AC File Offset: 0x000B3AAC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CGPR:A", this.a);
	}

	// Token: 0x06002251 RID: 8785 RVA: 0x000B58C8 File Offset: 0x000B3AC8
	public dbg(ap9 A_0, int A_1) : base(A_0)
	{
		this.a = A_1;
	}

	// Token: 0x06002252 RID: 8786 RVA: 0x000B58D8 File Offset: 0x000B3AD8
	public bool a()
	{
		return false;
	}

	// Token: 0x06002253 RID: 8787 RVA: 0x000B58E0 File Offset: 0x000B3AE0
	public List<string> b()
	{
		return new List<string>
		{
			TimelapseTextFeeds.Chat.ToString(),
			TimelapseTextFeeds.Combat.ToString()
		};
	}

	// Token: 0x06002254 RID: 8788 RVA: 0x000B591C File Offset: 0x000B3B1C
	public ecs se()
	{
		if (base.h() != null && !string.IsNullOrEmpty(base.h().a))
		{
			ecs ecs = new ecs();
			dl6 dl = new dl6();
			dl.a.Add(new bph(bvm.a(), string.Format("- {0} получает ", base.h()), null));
			dl.a.Add(new bph(bvm.a(adi.z), this.a.ToString(), null));
			dl.a.Add(new bph(bvm.a(), " резервных пси-очков.", null));
			ecs.a.Add(dl);
			return ecs;
		}
		return null;
	}

	// Token: 0x04001474 RID: 5236
	private int a;
}
