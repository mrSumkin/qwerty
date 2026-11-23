using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;

// Token: 0x02001049 RID: 4169
[eiz("SAFTFTJ")]
[Serializable]
public sealed class bik : cze
{
	// Token: 0x0600565F RID: 22111 RVA: 0x0025EE28 File Offset: 0x0025D028
	private bik(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005660 RID: 22112 RVA: 0x0025EE34 File Offset: 0x0025D034
	public bik()
	{
	}

	// Token: 0x06005661 RID: 22113 RVA: 0x0025EE40 File Offset: 0x0025D040
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			bv9 bv = serviceOrThrow.aqu().ac() as bv9;
			FieldInfo[] fields = typeof(asp).GetFields(BindingFlags.Static | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			{
				string text = fields[i].GetValue(null) as string;
				if (text != asp.a)
				{
					bqi bqi = bv.abt(text);
					if (bqi != null)
					{
						bqi.a(true);
					}
				}
			}
		}
	}
}
