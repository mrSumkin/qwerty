using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;

// Token: 0x0200110C RID: 4364
[eiz("SGPJ")]
[Serializable]
public sealed class c4f : cze, ISerializable
{
	// Token: 0x06005CAF RID: 23727 RVA: 0x00279588 File Offset: 0x00277788
	private c4f(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("SGPJ:P", typeof(PropertyCollection)) as PropertyCollection);
	}

	// Token: 0x06005CB0 RID: 23728 RVA: 0x002795C0 File Offset: 0x002777C0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SGPJ:P", this.a);
	}

	// Token: 0x170001BD RID: 445
	// (get) Token: 0x06005CB1 RID: 23729 RVA: 0x002795DC File Offset: 0x002777DC
	// (set) Token: 0x06005CB2 RID: 23730 RVA: 0x002795E4 File Offset: 0x002777E4
	public PropertyCollection Properties
	{
		get
		{
			return this.a;
		}
		set
		{
			this.a = value;
		}
	}

	// Token: 0x06005CB3 RID: 23731 RVA: 0x002795F0 File Offset: 0x002777F0
	public c4f()
	{
	}

	// Token: 0x06005CB4 RID: 23732 RVA: 0x00279608 File Offset: 0x00277808
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (this.a != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				foreach (Property property in this.a.Properties)
				{
					serviceOrThrow.aqu().r().SetPropertyValue(property.Name, property.Value);
				}
			}
		}
	}

	// Token: 0x040024FE RID: 9470
	private new PropertyCollection a = new PropertyCollection();
}
