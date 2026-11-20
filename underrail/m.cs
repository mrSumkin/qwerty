using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Common;

// Token: 0x02000545 RID: 1349
[eiz("FGE")]
[Serializable]
public sealed class m : aeq, b2h, ISerializable
{
	// Token: 0x06002287 RID: 8839 RVA: 0x000B65AC File Offset: 0x000B47AC
	private m(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("FGE:F");
	}

	// Token: 0x06002288 RID: 8840 RVA: 0x000B65C8 File Offset: 0x000B47C8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("FGE:F", this.a);
	}

	// Token: 0x06002289 RID: 8841 RVA: 0x000B65E4 File Offset: 0x000B47E4
	public string c()
	{
		return this.a;
	}

	// Token: 0x0600228A RID: 8842 RVA: 0x000B65EC File Offset: 0x000B47EC
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600228B RID: 8843 RVA: 0x000B65F8 File Offset: 0x000B47F8
	public m(ap9 A_0, string A_1) : base(A_0)
	{
		this.a = A_1;
	}

	// Token: 0x0600228C RID: 8844 RVA: 0x000B6608 File Offset: 0x000B4808
	public bool a()
	{
		return true;
	}

	// Token: 0x0600228D RID: 8845 RVA: 0x000B6610 File Offset: 0x000B4810
	public List<string> b()
	{
		return new List<string>
		{
			TimelapseTextFeeds.Chat.ToString(),
			TimelapseTextFeeds.Combat.ToString()
		};
	}

	// Token: 0x0600228E RID: 8846 RVA: 0x000B664C File Offset: 0x000B484C
	public ecs se()
	{
		if (!string.IsNullOrEmpty(base.h().a) && !string.IsNullOrEmpty(this.a))
		{
			ai8 ai = ck.a(this.a);
			if (ai != null)
			{
				ecs ecs = new ecs();
				dl6 dl = new dl6();
				dl.a.Add(new bph(bvm.a(), "- Получено умение: ", null));
				dl.a.Add(new bph(bvm.a(adi.c), ai.LocalizedName, null));
				dl.a.Add(new bph(bvm.a(), ".", null));
				ecs.a.Add(dl);
				return ecs;
			}
		}
		return null;
	}

	// Token: 0x04001480 RID: 5248
	private string a;
}
