using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Common;

// Token: 0x02000547 RID: 1351
[eiz("ICE")]
[Serializable]
public sealed class erv : aeq, b2h, ISerializable
{
	// Token: 0x06002295 RID: 8853 RVA: 0x000B68BC File Offset: 0x000B4ABC
	private erv(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (coh)A_0.GetValue("ICE:I", typeof(coh));
			return;
		}
		if (base.GetType() == typeof(erv))
		{
			this.a = (coh)A_0.GetValue("_Item", typeof(coh));
			return;
		}
		this.a = (coh)A_0.GetValue("ItemCraftedEvent+_Item", typeof(coh));
	}

	// Token: 0x06002296 RID: 8854 RVA: 0x000B6958 File Offset: 0x000B4B58
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ICE:I", this.a);
	}

	// Token: 0x06002297 RID: 8855 RVA: 0x000B6974 File Offset: 0x000B4B74
	public erv(ap9 A_0, coh A_1) : base(A_0)
	{
		this.a = A_1;
	}

	// Token: 0x06002298 RID: 8856 RVA: 0x000B6984 File Offset: 0x000B4B84
	public bool a()
	{
		return false;
	}

	// Token: 0x06002299 RID: 8857 RVA: 0x000B698C File Offset: 0x000B4B8C
	public List<string> b()
	{
		return new List<string>
		{
			TimelapseTextFeeds.Chat.ToString(),
			TimelapseTextFeeds.Combat.ToString()
		};
	}

	// Token: 0x0600229A RID: 8858 RVA: 0x000B69C8 File Offset: 0x000B4BC8
	public ecs se()
	{
		if (this.a != null && this.a.Definition != null && base.h() != null && !string.IsNullOrEmpty(base.h().a))
		{
			ecs ecs = new ecs();
			dl6 dl = new dl6();
			dl.a.Add(new bph(bvm.a(), string.Format("- {0} создаёт: ", base.h().a()), null));
			dl.a.Add(new bph(bvm.a(adi.ag[this.a.Definition.bc()]), this.a.Definition.az(), null));
			dl.a.Add(new bph(bvm.a(), string.Format("{0}.", (this.a.Stacks > 1) ? (" x " + this.a.Stacks.ToString()) : ""), null));
			ecs.a.Add(dl);
			return ecs;
		}
		return null;
	}

	// Token: 0x04001484 RID: 5252
	private coh a;
}
