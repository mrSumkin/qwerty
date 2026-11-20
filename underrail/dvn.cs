using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010C1 RID: 4289
[eiz("OLM")]
[Serializable]
public sealed class dvn : cze
{
	// Token: 0x06005A2A RID: 23082 RVA: 0x0026E4F8 File Offset: 0x0026C6F8
	private dvn(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("OLM:L");
		this.b = A_0.GetString("OLM:M");
		this.c = (A_0.GetValue("OLM:V", typeof(float?)) as float?);
	}

	// Token: 0x06005A2B RID: 23083 RVA: 0x0026E554 File Offset: 0x0026C754
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("OLM:L", this.a);
		info.AddValue("OLM:M", this.b);
		info.AddValue("OLM:V", this.c);
	}

	// Token: 0x06005A2C RID: 23084 RVA: 0x0026E5A4 File Offset: 0x0026C7A4
	public string b()
	{
		return this.a;
	}

	// Token: 0x06005A2D RID: 23085 RVA: 0x0026E5AC File Offset: 0x0026C7AC
	public void b(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005A2E RID: 23086 RVA: 0x0026E5B8 File Offset: 0x0026C7B8
	public string c()
	{
		return this.b;
	}

	// Token: 0x06005A2F RID: 23087 RVA: 0x0026E5C0 File Offset: 0x0026C7C0
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005A30 RID: 23088 RVA: 0x0026E5CC File Offset: 0x0026C7CC
	public float? a()
	{
		return this.c;
	}

	// Token: 0x06005A31 RID: 23089 RVA: 0x0026E5D4 File Offset: 0x0026C7D4
	public void a(float? A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005A32 RID: 23090 RVA: 0x0026E5E0 File Offset: 0x0026C7E0
	public dvn()
	{
	}

	// Token: 0x06005A33 RID: 23091 RVA: 0x0026E5E8 File Offset: 0x0026C7E8
	public dvn(string A_0, string A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x06005A34 RID: 23092 RVA: 0x0026E600 File Offset: 0x0026C800
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (!string.IsNullOrEmpty(this.a))
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				bfc bfc = serviceOrThrow.ar0(this.a, serviceOrThrow.aqu());
				if (bfc != null)
				{
					if (this.b != null)
					{
						serviceOrThrow.aqu().r()["MusicOverride_" + bfc.Id] = this.b;
					}
					else
					{
						serviceOrThrow.aqu().r().RemoveProperty("MusicOverride_" + bfc.Id);
					}
					if (this.c != null)
					{
						serviceOrThrow.aqu().r()["MusicOverride_" + bfc.Id + "_Volume"] = this.c;
					}
					else
					{
						serviceOrThrow.aqu().r().RemoveProperty("MusicOverride_" + bfc.Id + "_Volume");
					}
					serviceOrThrow.arw();
				}
			}
		}
	}

	// Token: 0x04002424 RID: 9252
	private new string a;

	// Token: 0x04002425 RID: 9253
	private string b;

	// Token: 0x04002426 RID: 9254
	private float? c;
}
