using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;
using Ouroboros.Common.Data;

// Token: 0x02000281 RID: 641
[cnn("Ouroboros.Playfield.Design.Forms.CustomDataAspectEditorForm, Ouroboros.Playfield.Design")]
[eiz("CDEA")]
[Serializable]
public sealed class a3f : Aspect<b0b>, ISerializable
{
	// Token: 0x060012AA RID: 4778 RVA: 0x0004DC9C File Offset: 0x0004BE9C
	private a3f(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() != 0)
		{
			this.a = (PropertyCollection)A_0.GetValue("CDEA:D", typeof(PropertyCollection));
			return;
		}
		this.a = (A_0.GetValue("_Data", typeof(PropertyCollection)) as PropertyCollection);
	}

	// Token: 0x060012AB RID: 4779 RVA: 0x0004DD08 File Offset: 0x0004BF08
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CDEA:D", this.a);
	}

	// Token: 0x060012AC RID: 4780 RVA: 0x0004DD24 File Offset: 0x0004BF24
	public PropertyCollection a()
	{
		return this.a;
	}

	// Token: 0x060012AD RID: 4781 RVA: 0x0004DD2C File Offset: 0x0004BF2C
	public void a(PropertyCollection A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060012AE RID: 4782 RVA: 0x0004DD38 File Offset: 0x0004BF38
	public a3f(b0b A_0) : base(A_0)
	{
	}

	// Token: 0x060012AF RID: 4783 RVA: 0x0004DD50 File Offset: 0x0004BF50
	public static Dictionary<string, object> a(b0b A_0)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		if (A_0 != null)
		{
			a3f aspect = A_0.GetAspect<a3f>();
			if (aspect != null && aspect.a() != null && aspect.a().Properties != null)
			{
				foreach (Property property in aspect.a().Properties)
				{
					if (!string.IsNullOrEmpty(property.Name))
					{
						dictionary[property.Name] = property.Value;
					}
				}
			}
		}
		return dictionary;
	}

	// Token: 0x04000A4D RID: 2637
	private PropertyCollection a = new PropertyCollection();
}
