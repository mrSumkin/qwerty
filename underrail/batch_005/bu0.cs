using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Common;

// Token: 0x020010A5 RID: 4261
[eiz("SGJ3")]
[Serializable]
public sealed class bu0 : cze, ISerializable
{
	// Token: 0x06005965 RID: 22885 RVA: 0x0026A2D4 File Offset: 0x002684D4
	private bu0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("SGJ3:G");
	}

	// Token: 0x06005966 RID: 22886 RVA: 0x0026A2F0 File Offset: 0x002684F0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SGJ3:G", this.a);
	}

	// Token: 0x06005967 RID: 22887 RVA: 0x0026A30C File Offset: 0x0026850C
	public string a()
	{
		return this.a;
	}

	// Token: 0x06005968 RID: 22888 RVA: 0x0026A314 File Offset: 0x00268514
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005969 RID: 22889 RVA: 0x0026A320 File Offset: 0x00268520
	public bu0()
	{
	}

	// Token: 0x0600596A RID: 22890 RVA: 0x0026A328 File Offset: 0x00268528
	public bu0(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600596B RID: 22891 RVA: 0x0026A338 File Offset: 0x00268538
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (!string.IsNullOrWhiteSpace(this.a))
		{
			string text = bdo.a(this.a);
			bpo.GetServiceOrThrow<d4m>().avp(dla.a(TimelapseWorkflows.SaveGame, new object[]
			{
				text
			}));
		}
	}

	// Token: 0x040023EF RID: 9199
	private new string a;
}
