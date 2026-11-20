using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;

// Token: 0x0200010B RID: 267
[eiz("WR")]
[Serializable]
public class ai : b8q, ISerializable
{
	// Token: 0x06000659 RID: 1625 RVA: 0x0001B3D0 File Offset: 0x000195D0
	protected ai(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() != 0)
		{
			di7.ReadDictionary<string, bq8>("WR:C", ref this.a, A_0);
			return;
		}
		if (base.GetType() == typeof(ai))
		{
			this.a = (Dictionary<string, bq8>)A_0.GetValue("_Contexts", typeof(Dictionary<string, bq8>));
			return;
		}
		this.a = (Dictionary<string, bq8>)A_0.GetValue("WorkflowRoot+_Contexts", typeof(Dictionary<string, bq8>));
	}

	// Token: 0x0600065A RID: 1626 RVA: 0x0001B468 File Offset: 0x00019668
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteDictionary<string, bq8>("WR:C", this.a, info);
	}

	// Token: 0x0600065B RID: 1627 RVA: 0x0001B484 File Offset: 0x00019684
	public static bool b()
	{
		return ai.b;
	}

	// Token: 0x0600065C RID: 1628 RVA: 0x0001B490 File Offset: 0x00019690
	public static void a(bool A_0)
	{
		ai.b = A_0;
	}

	// Token: 0x0600065D RID: 1629 RVA: 0x0001B49C File Offset: 0x0001969C
	public ai() : base(new btm[0])
	{
		this.a();
	}

	// Token: 0x0600065E RID: 1630 RVA: 0x0001B4BC File Offset: 0x000196BC
	public ai(Dictionary<string, bq8> A_0) : base(new btm[0])
	{
		if (A_0 != null)
		{
			this.a = A_0;
		}
		this.a();
	}

	// Token: 0x0600065F RID: 1631 RVA: 0x0001B4E8 File Offset: 0x000196E8
	public ai(params btm[] A_0) : base(A_0)
	{
		this.a();
	}

	// Token: 0x06000660 RID: 1632 RVA: 0x0001B504 File Offset: 0x00019704
	public ai(string A_0, params btm[] A_1) : base(A_0, A_1)
	{
		this.a();
	}

	// Token: 0x06000661 RID: 1633 RVA: 0x0001B520 File Offset: 0x00019720
	public ai(string A_0, Dictionary<string, bq8> A_1, params btm[] A_2) : base(A_0, A_2)
	{
		if (A_1 != null)
		{
			this.a = A_1;
		}
		this.a();
	}

	// Token: 0x06000662 RID: 1634 RVA: 0x0001B548 File Offset: 0x00019748
	public void a(string A_0, bq8 A_1)
	{
		this.a[A_0] = A_1;
	}

	// Token: 0x06000663 RID: 1635 RVA: 0x0001B558 File Offset: 0x00019758
	public object a(string A_0, string A_1)
	{
		czh.a(A_0, "contextName");
		czh.a(A_1, "propertyName");
		if (this.a != null)
		{
			bq8 bq;
			this.a.TryGetValue(A_0, out bq);
			if (bq != null)
			{
				return bq.get_Item(A_1);
			}
		}
		return null;
	}

	// Token: 0x06000664 RID: 1636 RVA: 0x0001B5A4 File Offset: 0x000197A4
	public void a(string A_0, string A_1, object A_2)
	{
		czh.a(A_0, "contextName");
		czh.a(A_1, "propertyName");
		if (this.a != null)
		{
			bq8 bq;
			this.a.TryGetValue(A_0, out bq);
			if (bq != null)
			{
				bq.set_Item(A_1, A_2);
			}
		}
	}

	// Token: 0x06000665 RID: 1637 RVA: 0x0001B5F0 File Offset: 0x000197F0
	protected override bool b4(e6d A_0)
	{
		this.a();
		return base.b4(A_0);
	}

	// Token: 0x06000666 RID: 1638 RVA: 0x0001B600 File Offset: 0x00019800
	private void a()
	{
		if (this.a == null)
		{
			this.a = new Dictionary<string, bq8>();
		}
		if (!this.a.ContainsKey(ddb.a))
		{
			this.a(ddb.a, new PropertyCollection());
		}
	}

	// Token: 0x04000512 RID: 1298
	private new Dictionary<string, bq8> a = new Dictionary<string, bq8>();

	// Token: 0x04000513 RID: 1299
	private new static volatile bool b;
}
