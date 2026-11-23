using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200065F RID: 1631
[eiz("G30")]
[Serializable]
public sealed class e82 : ISerializable
{
	// Token: 0x06002965 RID: 10597 RVA: 0x000EBDA8 File Offset: 0x000E9FA8
	private e82(SerializationInfo A_0, StreamingContext A_1)
	{
		di7.ReadDictionary<string, cka>("G30:E", ref this.a, A_0);
	}

	// Token: 0x06002966 RID: 10598 RVA: 0x000EBDCC File Offset: 0x000E9FCC
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		di7.WriteDictionary<string, cka>("G30:E", this.a, info);
	}

	// Token: 0x06002967 RID: 10599 RVA: 0x000EBDE0 File Offset: 0x000E9FE0
	public Dictionary<string, cka> a()
	{
		return this.a;
	}

	// Token: 0x06002968 RID: 10600 RVA: 0x000EBDE8 File Offset: 0x000E9FE8
	public e82()
	{
	}

	// Token: 0x06002969 RID: 10601 RVA: 0x000EBDFC File Offset: 0x000E9FFC
	public cka a(string A_0)
	{
		cka cka;
		this.a.TryGetValue(A_0, out cka);
		if (cka == null)
		{
			cka = new cka(A_0, null);
			this.a.Add(A_0, cka);
		}
		return cka;
	}

	// Token: 0x0600296A RID: 10602 RVA: 0x000EBE34 File Offset: 0x000EA034
	public cka b(string A_0)
	{
		cka result;
		this.a.TryGetValue(A_0, out result);
		return result;
	}

	// Token: 0x0600296B RID: 10603 RVA: 0x000EBE54 File Offset: 0x000EA054
	public bool a(string A_0, out b0b A_1, out bhb A_2, out TimeSpan? A_3)
	{
		cka cka;
		this.a.TryGetValue(A_0, out cka);
		if (cka != null)
		{
			if (!cka.a())
			{
				A_1 = cka.b();
			}
			else
			{
				A_1 = null;
			}
			cka.c();
			A_2 = cka.d();
			A_3 = cka.e();
			return true;
		}
		A_1 = null;
		A_2 = null;
		A_3 = null;
		return false;
	}

	// Token: 0x04001698 RID: 5784
	private Dictionary<string, cka> a = new Dictionary<string, cka>();
}
