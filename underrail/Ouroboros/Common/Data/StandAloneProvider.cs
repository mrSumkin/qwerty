using System;
using System.Runtime.Serialization;

namespace Ouroboros.Common.Data
{
	// Token: 0x02002217 RID: 8727
	[eiz("SAP")]
	[Serializable]
	public class StandAloneProvider<T> : IProvider<T>, ISerializable where T : class
	{
		// Token: 0x0600CA90 RID: 51856 RVA: 0x0047C478 File Offset: 0x0047A678
		protected StandAloneProvider(SerializationInfo A_0, StreamingContext A_1)
		{
			if (ell.b() != 0)
			{
				this.a = (T)((object)A_0.GetValue("SAP:V", typeof(T)));
				return;
			}
			if (base.GetType() == typeof(StandAloneProvider<T>))
			{
				this.a = (T)((object)A_0.GetValue("_Value", typeof(T)));
				return;
			}
			this.a = (T)((object)A_0.GetValue("StandAloneProvider`1+_Value", typeof(T)));
		}

		// Token: 0x0600CA91 RID: 51857 RVA: 0x0047C514 File Offset: 0x0047A714
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("SAP:V", this.a);
		}

		// Token: 0x0600CA92 RID: 51858 RVA: 0x0047C52C File Offset: 0x0047A72C
		public T ao()
		{
			return this.a;
		}

		// Token: 0x0600CA93 RID: 51859 RVA: 0x0047C534 File Offset: 0x0047A734
		public StandAloneProvider(T A_0)
		{
			this.a = A_0;
		}

		// Token: 0x04004A18 RID: 18968
		private T a;
	}
}
