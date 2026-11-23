using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Common;

// Token: 0x0200053C RID: 1340
[eiz("BDE")]
[Serializable]
public sealed class csv : b9g, b2h, ISerializable
{
	// Token: 0x06002249 RID: 8777 RVA: 0x000B576C File Offset: 0x000B396C
	private csv(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(csv);
		}
	}

	// Token: 0x0600224A RID: 8778 RVA: 0x000B5798 File Offset: 0x000B3998
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600224B RID: 8779 RVA: 0x000B57A4 File Offset: 0x000B39A4
	public csv(ap9 A_0, string A_1, cr1 A_2) : base(A_0, A_1, A_2)
	{
	}

	// Token: 0x0600224C RID: 8780 RVA: 0x000B57B0 File Offset: 0x000B39B0
	public bool a()
	{
		return false;
	}

	// Token: 0x0600224D RID: 8781 RVA: 0x000B57B4 File Offset: 0x000B39B4
	public List<string> b()
	{
		return new List<string>
		{
			TimelapseTextFeeds.Chat.ToString(),
			TimelapseTextFeeds.Combat.ToString()
		};
	}

	// Token: 0x0600224E RID: 8782 RVA: 0x000B57F0 File Offset: 0x000B39F0
	public ecs se()
	{
		if (!string.IsNullOrEmpty(base.h().a))
		{
			ecs ecs = new ecs();
			dl6 dl = new dl6();
			dl.a.Add(new bph(bvm.a(), "- Загружен новый чертёж: ", null));
			dl.a.Add(new bph(bvm.a(adi.ag[base.c()]), base.d(), null));
			dl.a.Add(new bph(bvm.a(), ".", null));
			ecs.a.Add(dl);
			return ecs;
		}
		return null;
	}
}
