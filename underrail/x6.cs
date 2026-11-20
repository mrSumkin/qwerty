using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010E5 RID: 4325
[eiz("MGCJ")]
[Serializable]
public sealed class x6 : cze, ISerializable
{
	// Token: 0x06005B42 RID: 23362 RVA: 0x00273C14 File Offset: 0x00271E14
	private x6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("MGCJ:N");
		this.b = A_0.GetInt32("MGCJ:A");
		this.c = A_0.GetBoolean("MGCJ:C");
	}

	// Token: 0x06005B43 RID: 23363 RVA: 0x00273C6C File Offset: 0x00271E6C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MGCJ:N", this.a);
		info.AddValue("MGCJ:A", this.b);
		info.AddValue("MGCJ:C", this.c);
	}

	// Token: 0x06005B44 RID: 23364 RVA: 0x00273CB4 File Offset: 0x00271EB4
	public string c()
	{
		return this.a;
	}

	// Token: 0x06005B45 RID: 23365 RVA: 0x00273CBC File Offset: 0x00271EBC
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005B46 RID: 23366 RVA: 0x00273CC8 File Offset: 0x00271EC8
	public int b()
	{
		return this.b;
	}

	// Token: 0x06005B47 RID: 23367 RVA: 0x00273CD0 File Offset: 0x00271ED0
	public void a(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005B48 RID: 23368 RVA: 0x00273CDC File Offset: 0x00271EDC
	public bool a()
	{
		return this.c;
	}

	// Token: 0x06005B49 RID: 23369 RVA: 0x00273CE4 File Offset: 0x00271EE4
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005B4A RID: 23370 RVA: 0x00273CF0 File Offset: 0x00271EF0
	public x6()
	{
	}

	// Token: 0x06005B4B RID: 23371 RVA: 0x00273D0C File Offset: 0x00271F0C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (!string.IsNullOrEmpty(this.a))
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				int? primitivePropertyValue = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>(this.a, null);
				if (primitivePropertyValue == null)
				{
					if (!this.c)
					{
						return;
					}
					primitivePropertyValue = new int?(0);
				}
				serviceOrThrow.aqu().r()[this.a] = primitivePropertyValue.Value + this.b;
			}
		}
	}

	// Token: 0x04002475 RID: 9333
	private new string a;

	// Token: 0x04002476 RID: 9334
	private int b = 1;

	// Token: 0x04002477 RID: 9335
	private bool c = true;
}
