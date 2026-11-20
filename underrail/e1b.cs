using System;
using System.Runtime.Serialization;

// Token: 0x020004FC RID: 1276
[eiz("SQA")]
[Serializable]
public sealed class e1b : esc, ISerializable
{
	// Token: 0x06002103 RID: 8451 RVA: 0x000B10AC File Offset: 0x000AF2AC
	private e1b(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.b = A_0.GetString("SQA:QN");
			if (ell.a() >= 16)
			{
				this.a = A_0.GetBoolean("SQA:PE");
				return;
			}
			this.a = true;
			return;
		}
		else
		{
			if (base.GetType() == typeof(e1b))
			{
				this.b = A_0.GetString("_QuestName");
				return;
			}
			this.b = A_0.GetString("StartQuestAction+_QuestName");
			return;
		}
	}

	// Token: 0x06002104 RID: 8452 RVA: 0x000B1148 File Offset: 0x000AF348
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SQA:QN", this.b);
		info.AddValue("SQA:PE", this.a);
	}

	// Token: 0x06002105 RID: 8453 RVA: 0x000B1174 File Offset: 0x000AF374
	public bool b()
	{
		return this.a;
	}

	// Token: 0x06002106 RID: 8454 RVA: 0x000B117C File Offset: 0x000AF37C
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002107 RID: 8455 RVA: 0x000B1188 File Offset: 0x000AF388
	public string a()
	{
		return this.b;
	}

	// Token: 0x06002108 RID: 8456 RVA: 0x000B1190 File Offset: 0x000AF390
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06002109 RID: 8457 RVA: 0x000B119C File Offset: 0x000AF39C
	public override int d5(bq8 A_0, bq8 A_1)
	{
		bpo.GetServiceOrThrow<cnk>().aqz().atb(this.a(), this.a);
		return 0;
	}

	// Token: 0x0600210A RID: 8458 RVA: 0x000B11BC File Offset: 0x000AF3BC
	public e1b()
	{
	}

	// Token: 0x0600210B RID: 8459 RVA: 0x000B11D0 File Offset: 0x000AF3D0
	public override bool h5(string A_0, bool A_1)
	{
		return !base.h5(A_0, A_1) && !string.IsNullOrEmpty(this.b) && this.b.IndexOf(A_0, A_1 ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase) != -1;
	}

	// Token: 0x0400143A RID: 5178
	private bool a = true;

	// Token: 0x0400143B RID: 5179
	private string b;
}
