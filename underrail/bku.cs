using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;

// Token: 0x02001125 RID: 4389
[eiz("MGDJ")]
[Serializable]
public sealed class bku : cze, ISerializable
{
	// Token: 0x06005DD0 RID: 24016 RVA: 0x0027CDA8 File Offset: 0x0027AFA8
	private bku(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (PropertyCollection)A_0.GetValue("MGDJ:M", typeof(PropertyCollection));
			this.b = (beu)A_0.GetValue("MGDJ:MT", typeof(beu));
			return;
		}
		if (base.GetType() == typeof(bku))
		{
			this.a = (PropertyCollection)A_0.GetValue("_Modifications", typeof(PropertyCollection));
			this.b = (beu)A_0.GetValue("_ModificationType", typeof(beu));
			return;
		}
		this.a = (PropertyCollection)A_0.GetValue("ModifyGameDataJob+_Modifications", typeof(PropertyCollection));
		this.b = (beu)A_0.GetValue("ModifyGameDataJob+_ModificationType", typeof(beu));
	}

	// Token: 0x06005DD1 RID: 24017 RVA: 0x0027CEB0 File Offset: 0x0027B0B0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MGDJ:M", this.a);
		info.AddValue("MGDJ:MT", this.b);
	}

	// Token: 0x06005DD2 RID: 24018 RVA: 0x0027CEE4 File Offset: 0x0027B0E4
	public PropertyCollection a()
	{
		return this.a;
	}

	// Token: 0x06005DD3 RID: 24019 RVA: 0x0027CEEC File Offset: 0x0027B0EC
	public void a(PropertyCollection A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005DD4 RID: 24020 RVA: 0x0027CEF8 File Offset: 0x0027B0F8
	public beu b()
	{
		return this.b;
	}

	// Token: 0x06005DD5 RID: 24021 RVA: 0x0027CF00 File Offset: 0x0027B100
	public void a(beu A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005DD6 RID: 24022 RVA: 0x0027CF0C File Offset: 0x0027B10C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.a != null)
		{
			foreach (Property property in this.a.Properties)
			{
				if (!string.IsNullOrEmpty(property.Name))
				{
					if (this.b == beu.a)
					{
						serviceOrThrow.aqu().r()[property.Name] = property.Value;
					}
					else
					{
						evr.a(serviceOrThrow.aqu().r(), property, this.b == beu.c);
					}
				}
			}
		}
	}

	// Token: 0x04002557 RID: 9559
	private new PropertyCollection a = new PropertyCollection();

	// Token: 0x04002558 RID: 9560
	private beu b;
}
