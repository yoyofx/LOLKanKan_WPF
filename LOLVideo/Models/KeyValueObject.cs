using ExtendPropertyLib;

namespace LOLVideo.Models
{
    /// <summary>
    /// 键值对象基类
    /// </summary>
    /// <typeparam name="TKey">键类型</typeparam>
    /// <typeparam name="TValue">值类型</typeparam>
    public class KeyValueObject<TKey,TValue> : BusinessInfoBase<KeyValueObject<TKey,TValue>>
    {

        public static ExtendProperty KeyProperty = RegisterProperty(v => v.Key);
        /// <summary>
        /// 键名
        /// </summary>
        public TKey Key { set { SetValue(KeyProperty, value); } get { return (TKey)GetValue(KeyProperty); } }


        public static ExtendProperty ValueProperty = RegisterProperty(v => v.Value);
        /// <summary>
        /// 键值
        /// </summary>
        public TValue Value { set { SetValue(ValueProperty, value); } get { return (TValue)GetValue(ValueProperty); } }

    }
}
