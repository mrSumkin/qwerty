using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Common;

// Token: 0x02000544 RID: 1348
[eiz("P44")]
[Serializable]
public sealed class es8 : aeq, b2h, ISerializable
{
	// Token: 0x0600227F RID: 8831 RVA: 0x000B6458 File Offset: 0x000B4658
	private es8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("P44:F");
	}

	// Token: 0x06002280 RID: 8832 RVA: 0x000B6474 File Offset: 0x000B4674
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("P44:F", this.a);
	}

	// Token: 0x06002281 RID: 8833 RVA: 0x000B6490 File Offset: 0x000B4690
	public string c()
	{
		return this.a;
	}

	// Token: 0x06002282 RID: 8834 RVA: 0x000B6498 File Offset: 0x000B4698
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002283 RID: 8835 RVA: 0x000B64A4 File Offset: 0x000B46A4
	public es8(ap9 A_0, string A_1) : base(A_0)
	{
		this.a = A_1;
	}

	// Token: 0x06002284 RID: 8836 RVA: 0x000B64B4 File Offset: 0x000B46B4
	public bool a()
	{
		return true;
	}

	// Token: 0x06002285 RID: 8837 RVA: 0x000B64BC File Offset: 0x000B46BC
	public List<string> b()
	{
		return new List<string>
		{
			TimelapseTextFeeds.Chat.ToString(),
			TimelapseTextFeeds.Combat.ToString()
		};
	}

	// Token: 0x06002286 RID: 8838 RVA: 0x000B64F8 File Offset: 0x000B46F8
	public ecs se()
	{
		if (!string.IsNullOrEmpty(base.h().a) && !string.IsNullOrEmpty(this.a))
		{
			c3n c3n = dgk.a(this.a);
			if (c3n != null)
			{
				ecs ecs = new ecs();
				dl6 dl = new dl6();
				dl.a.Add(new bph(bvm.a(), "- Получена пси-способность: ", null));
				dl.a.Add(new bph(bvm.a(adi.c), c3n.LocalizedName, null));
				dl.a.Add(new bph(bvm.a(), ".", null));
				ecs.a.Add(dl);
				return ecs;
			}
		}
		return null;
	}

	// Token: 0x0400147F RID: 5247
	private string a;
}
