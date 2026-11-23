using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common;

// Token: 0x02000542 RID: 1346
[eiz("FLE")]
[Serializable]
public sealed class aoi : aeq, b2h, ISerializable
{
	// Token: 0x0600226D RID: 8813 RVA: 0x000B619C File Offset: 0x000B439C
	private aoi(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("FLE:F");
	}

	// Token: 0x0600226E RID: 8814 RVA: 0x000B61B8 File Offset: 0x000B43B8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("FLE:F", this.a);
	}

	// Token: 0x0600226F RID: 8815 RVA: 0x000B61D4 File Offset: 0x000B43D4
	public string c()
	{
		return this.a;
	}

	// Token: 0x06002270 RID: 8816 RVA: 0x000B61DC File Offset: 0x000B43DC
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002271 RID: 8817 RVA: 0x000B61E8 File Offset: 0x000B43E8
	public aoi(ap9 A_0, string A_1) : base(A_0)
	{
		this.a = A_1;
	}

	// Token: 0x06002272 RID: 8818 RVA: 0x000B61F8 File Offset: 0x000B43F8
	public bool a()
	{
		return true;
	}

	// Token: 0x06002273 RID: 8819 RVA: 0x000B61FC File Offset: 0x000B43FC
	public List<string> b()
	{
		return new List<string>
		{
			TimelapseTextFeeds.Chat.ToString(),
			TimelapseTextFeeds.Combat.ToString()
		};
	}

	// Token: 0x06002274 RID: 8820 RVA: 0x000B6238 File Offset: 0x000B4438
	public ecs se()
	{
		if (!string.IsNullOrEmpty(base.h().a) && !string.IsNullOrEmpty(this.a))
		{
			ai8 ai = ck.a(this.a);
			if (ai != null)
			{
				ecs ecs = new ecs();
				dl6 dl = new dl6();
				dl.a.Add(new bph(bvm.a(Color.OrangeRed), "- Умение утеряно: ", null));
				dl.a.Add(new bph(bvm.a(Color.OrangeRed), ai.LocalizedName, null));
				dl.a.Add(new bph(bvm.a(Color.OrangeRed), ".", null));
				ecs.a.Add(dl);
				return ecs;
			}
		}
		return null;
	}

	// Token: 0x0400147C RID: 5244
	private string a;
}
