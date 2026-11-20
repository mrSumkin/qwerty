using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common;

// Token: 0x02000520 RID: 1312
[eiz("GLNE")]
[Serializable]
public sealed class h0 : c47, b2h, ISerializable
{
	// Token: 0x060021C7 RID: 8647 RVA: 0x000B408C File Offset: 0x000B228C
	private h0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("GLNE:M");
			this.b = (Color?)A_0.GetValue("GLNE:TCO", typeof(Color?));
			return;
		}
		if (base.GetType() == typeof(h0))
		{
			this.a = A_0.GetString("_Message");
			this.b = (Color?)A_0.GetValue("_TextColorOverride", typeof(Color?));
			return;
		}
		this.a = A_0.GetString("GenericLocaleNarrationEvent+_Message");
		this.b = (Color?)A_0.GetValue("GenericLocaleNarrationEvent+_TextColorOverride", typeof(Color?));
	}

	// Token: 0x060021C8 RID: 8648 RVA: 0x000B415C File Offset: 0x000B235C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("GLNE:M", this.a);
		info.AddValue("GLNE:TCO", this.b);
	}

	// Token: 0x060021C9 RID: 8649 RVA: 0x000B4190 File Offset: 0x000B2390
	public string c()
	{
		return this.a;
	}

	// Token: 0x060021CA RID: 8650 RVA: 0x000B4198 File Offset: 0x000B2398
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060021CB RID: 8651 RVA: 0x000B41A4 File Offset: 0x000B23A4
	public h0(string A_0, Color? A_1 = null)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x060021CC RID: 8652 RVA: 0x000B41BC File Offset: 0x000B23BC
	public bool a()
	{
		return true;
	}

	// Token: 0x060021CD RID: 8653 RVA: 0x000B41C4 File Offset: 0x000B23C4
	public List<string> b()
	{
		return new List<string>
		{
			TimelapseTextFeeds.Chat.ToString(),
			TimelapseTextFeeds.Combat.ToString()
		};
	}

	// Token: 0x060021CE RID: 8654 RVA: 0x000B4200 File Offset: 0x000B2400
	public ecs se()
	{
		ecs ecs = new ecs();
		dl6 dl = new dl6();
		ecs.a.Add(dl);
		dl.a.Add(new bph(bvm.a((this.b != null) ? this.b.Value : adi.h), this.a, null));
		return ecs;
	}

	// Token: 0x04001463 RID: 5219
	private string a;

	// Token: 0x04001464 RID: 5220
	private Color? b;
}
