using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;
using Ouroboros.Core.Logging;

// Token: 0x020010C4 RID: 4292
[eiz("DADJ")]
[Serializable]
public sealed class edk : cze, ISerializable
{
	// Token: 0x06005A47 RID: 23111 RVA: 0x0026F530 File Offset: 0x0026D730
	private edk(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("DADJ:A");
		di7.ReadList<string>("DADJ:D", ref this.c, A_0);
		this.b = A_0.GetBoolean("DADJ:P");
	}

	// Token: 0x06005A48 RID: 23112 RVA: 0x0026F584 File Offset: 0x0026D784
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DADJ:A", this.a);
		info.AddValue("DADJ:P", this.b);
		di7.WriteList<string>("DADJ:D", this.c, info);
	}

	// Token: 0x06005A49 RID: 23113 RVA: 0x0026F5CC File Offset: 0x0026D7CC
	public string a()
	{
		return this.a;
	}

	// Token: 0x06005A4A RID: 23114 RVA: 0x0026F5D4 File Offset: 0x0026D7D4
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005A4B RID: 23115 RVA: 0x0026F5E0 File Offset: 0x0026D7E0
	public bool c()
	{
		return this.b;
	}

	// Token: 0x06005A4C RID: 23116 RVA: 0x0026F5E8 File Offset: 0x0026D7E8
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005A4D RID: 23117 RVA: 0x0026F5F4 File Offset: 0x0026D7F4
	public List<string> b()
	{
		return this.c;
	}

	// Token: 0x06005A4E RID: 23118 RVA: 0x0026F5FC File Offset: 0x0026D7FC
	public void a(List<string> A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005A4F RID: 23119 RVA: 0x0026F608 File Offset: 0x0026D808
	public edk()
	{
	}

	// Token: 0x06005A50 RID: 23120 RVA: 0x0026F620 File Offset: 0x0026D820
	public sealed override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			TypedObjectReference<bag> a_ = serviceOrThrow.aqu().v().c();
			aud aud = cze.a(this.a, A_0, A_1, A_2);
			if (aud != null)
			{
				foreach (string text in this.c)
				{
					if (!string.IsNullOrWhiteSpace(text))
					{
						cno cno = aud.Divinations.a(text);
						if (cno != null)
						{
							cno.b(a_);
						}
						else
						{
							dux.b(LogSeverity.Warning, "Failed to perform area segment divination. Could not retrieve divination '{0}' in area '{1}'.", new object[]
							{
								text,
								aud.y8()
							});
						}
					}
				}
			}
		}
	}

	// Token: 0x0400242F RID: 9263
	private new string a;

	// Token: 0x04002430 RID: 9264
	private bool b;

	// Token: 0x04002431 RID: 9265
	private List<string> c = new List<string>();
}
