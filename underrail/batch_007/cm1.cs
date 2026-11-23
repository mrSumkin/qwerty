using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000F5B RID: 3931
[eiz("PHM1")]
[Serializable]
public sealed class cm1 : dnh, ISerializable
{
	// Token: 0x06004FAA RID: 20394 RVA: 0x0023D5C0 File Offset: 0x0023B7C0
	private cm1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("PHM1:I");
	}

	// Token: 0x06004FAB RID: 20395 RVA: 0x0023D5DC File Offset: 0x0023B7DC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PHM1:I", this.a);
	}

	// Token: 0x06004FAC RID: 20396 RVA: 0x0023D5F8 File Offset: 0x0023B7F8
	public bool b()
	{
		return this.a;
	}

	// Token: 0x06004FAD RID: 20397 RVA: 0x0023D600 File Offset: 0x0023B800
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06004FAE RID: 20398 RVA: 0x0023D60C File Offset: 0x0023B80C
	public cm1()
	{
	}

	// Token: 0x06004FAF RID: 20399 RVA: 0x0023D614 File Offset: 0x0023B814
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		bool flag = false;
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			using (List<coh>.Enumerator enumerator = Enumerable.ToList<coh>(serviceOrThrow.aqu().v().Bag.z2()).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Definition is a54)
					{
						flag = true;
						break;
					}
				}
			}
		}
		return flag ^ this.a;
	}

	// Token: 0x06004FB0 RID: 20400 RVA: 0x0023D6BC File Offset: 0x0023B8BC
	public string a()
	{
		return "PlayerHasMoneyCondition";
	}

	// Token: 0x04002096 RID: 8342
	private bool a;
}
