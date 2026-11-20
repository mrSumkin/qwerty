using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001121 RID: 4385
[eiz("SZAJ")]
[Serializable]
public sealed class e80 : cze, ISerializable
{
	// Token: 0x06005D9F RID: 23967 RVA: 0x0027C070 File Offset: 0x0027A270
	private e80(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetBoolean("SZAJ:E");
			return;
		}
		if (base.GetType() == typeof(e80))
		{
			this.a = A_0.GetBoolean("_Enabled");
			return;
		}
		this.a = A_0.GetBoolean("SetZoneAiJob+_Enabled");
	}

	// Token: 0x06005DA0 RID: 23968 RVA: 0x0027C0E0 File Offset: 0x0027A2E0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SZAJ:E", this.a);
	}

	// Token: 0x06005DA1 RID: 23969 RVA: 0x0027C0FC File Offset: 0x0027A2FC
	public bool a()
	{
		return this.a;
	}

	// Token: 0x06005DA2 RID: 23970 RVA: 0x0027C104 File Offset: 0x0027A304
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005DA3 RID: 23971 RVA: 0x0027C110 File Offset: 0x0027A310
	public e80()
	{
	}

	// Token: 0x06005DA4 RID: 23972 RVA: 0x0027C118 File Offset: 0x0027A318
	public e80(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005DA5 RID: 23973 RVA: 0x0027C12C File Offset: 0x0027A32C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c1a c1a;
		if (A_1 != null && A_1.Zone != null)
		{
			c1a = A_1.Zone;
		}
		else if (A_0 != null && A_0.Zone != null)
		{
			c1a = A_0.Zone;
		}
		else
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqw() == null)
			{
				return;
			}
			c1a = serviceOrThrow.aqw();
		}
		if (!this.a)
		{
			d02 service = bpo.GetService<d02>();
			if (service != null && service.ahg())
			{
				service.ahr();
			}
		}
		c1a.CustomProperties[a46.a] = !this.a;
	}

	// Token: 0x04002547 RID: 9543
	private new bool a;
}
