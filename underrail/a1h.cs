using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common;

// Token: 0x02000543 RID: 1347
[eiz("GCEX")]
[Serializable]
public sealed class a1h : aeq, b2h, ISerializable
{
	// Token: 0x06002275 RID: 8821 RVA: 0x000B62F8 File Offset: 0x000B44F8
	private a1h(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("GCEX:M");
		this.b = (Color)A_0.GetValue("GCEX:C", typeof(Color));
	}

	// Token: 0x06002276 RID: 8822 RVA: 0x000B634C File Offset: 0x000B454C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("GCEX:M", this.a);
		info.AddValue("GCEX:C", this.b);
	}

	// Token: 0x06002277 RID: 8823 RVA: 0x000B6380 File Offset: 0x000B4580
	public string c()
	{
		return this.a;
	}

	// Token: 0x06002278 RID: 8824 RVA: 0x000B6388 File Offset: 0x000B4588
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002279 RID: 8825 RVA: 0x000B6394 File Offset: 0x000B4594
	public Color d()
	{
		return this.b;
	}

	// Token: 0x0600227A RID: 8826 RVA: 0x000B639C File Offset: 0x000B459C
	public void a(Color A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600227B RID: 8827 RVA: 0x000B63A8 File Offset: 0x000B45A8
	public a1h(ap9 A_0, string A_1, Color? A_2 = null) : base(A_0)
	{
		this.a = A_1;
		if (A_2 != null)
		{
			this.b = A_2.Value;
		}
	}

	// Token: 0x0600227C RID: 8828 RVA: 0x000B63DC File Offset: 0x000B45DC
	public bool a()
	{
		return false;
	}

	// Token: 0x0600227D RID: 8829 RVA: 0x000B63E0 File Offset: 0x000B45E0
	public List<string> b()
	{
		return new List<string>
		{
			TimelapseTextFeeds.Combat.ToString()
		};
	}

	// Token: 0x0600227E RID: 8830 RVA: 0x000B6408 File Offset: 0x000B4608
	public ecs se()
	{
		ecs ecs = new ecs();
		dl6 dl = new dl6();
		dl.a.Add(new bph(bvm.a(this.b), string.Format("- {0}", this.a), null));
		ecs.a.Add(dl);
		return ecs;
	}

	// Token: 0x0400147D RID: 5245
	private string a;

	// Token: 0x0400147E RID: 5246
	private Color b = Color.White;
}
