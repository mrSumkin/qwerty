using System;
using System.Runtime.Serialization;

// Token: 0x020004F8 RID: 1272
[eiz("PCA1")]
[Serializable]
public sealed class ehv : esc, ISerializable
{
	// Token: 0x060020E1 RID: 8417 RVA: 0x000B0B08 File Offset: 0x000AED08
	private ehv(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("PCA1:WP");
			return;
		}
		if (base.GetType() == typeof(ehv))
		{
			this.a = A_0.GetString("_WorkflowPath");
			return;
		}
		this.a = A_0.GetString("PlayCutsceneAction+_WorkflowPath");
	}

	// Token: 0x060020E2 RID: 8418 RVA: 0x000B0B78 File Offset: 0x000AED78
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PCA1:WP", this.a);
	}

	// Token: 0x060020E3 RID: 8419 RVA: 0x000B0B94 File Offset: 0x000AED94
	public string a()
	{
		return this.a;
	}

	// Token: 0x060020E4 RID: 8420 RVA: 0x000B0B9C File Offset: 0x000AED9C
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060020E5 RID: 8421 RVA: 0x000B0BA8 File Offset: 0x000AEDA8
	public override int d5(bq8 A_0, bq8 A_1)
	{
		if (!string.IsNullOrWhiteSpace(this.a))
		{
			bpo.GetServiceOrThrow<ps>().am3(this.a);
			return 0;
		}
		throw new Exception("Failed to execute PlayCutsceneAction. Workflow path was null or whitespace.");
	}

	// Token: 0x060020E6 RID: 8422 RVA: 0x000B0BD8 File Offset: 0x000AEDD8
	public ehv()
	{
	}

	// Token: 0x04001431 RID: 5169
	private string a;
}
