using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Common;

// Token: 0x02000540 RID: 1344
[eiz("CLPR")]
[Serializable]
public sealed class ahd : aeq, b2h, ISerializable
{
	// Token: 0x06002261 RID: 8801 RVA: 0x000B5F24 File Offset: 0x000B4124
	private ahd(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("CLPR:A");
	}

	// Token: 0x06002262 RID: 8802 RVA: 0x000B5F40 File Offset: 0x000B4140
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CLPR:A", this.a);
	}

	// Token: 0x06002263 RID: 8803 RVA: 0x000B5F5C File Offset: 0x000B415C
	public ahd(ap9 A_0, int A_1) : base(A_0)
	{
		this.a = A_1;
	}

	// Token: 0x06002264 RID: 8804 RVA: 0x000B5F6C File Offset: 0x000B416C
	public bool a()
	{
		return false;
	}

	// Token: 0x06002265 RID: 8805 RVA: 0x000B5F74 File Offset: 0x000B4174
	public List<string> b()
	{
		return new List<string>
		{
			TimelapseTextFeeds.Chat.ToString(),
			TimelapseTextFeeds.Combat.ToString()
		};
	}

	// Token: 0x06002266 RID: 8806 RVA: 0x000B5FB0 File Offset: 0x000B41B0
	public ecs se()
	{
		if (base.h() != null && !string.IsNullOrEmpty(base.h().a))
		{
			ecs ecs = new ecs();
			dl6 dl = new dl6();
			dl.a.Add(new bph(bvm.a(), string.Format("- {0} теряет ", base.h()), null));
			dl.a.Add(new bph(bvm.a(adi.aa), this.a.ToString(), null));
			dl.a.Add(new bph(bvm.a(), " резервных пси-очков.", null));
			ecs.a.Add(dl);
			return ecs;
		}
		return null;
	}

	// Token: 0x0400147A RID: 5242
	private int a;
}
